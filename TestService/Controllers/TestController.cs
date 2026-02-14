using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestService.Data;
using TestService.DTOS;
using TestService.Model;

namespace TestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("create-test")]
        public async Task<IActionResult> CreateTest(CreateMcqTestDto dto)
        {
           if(!await _context.Companies.AnyAsync(c => c.Id == dto.CompanyId))
            {
                return BadRequest("Company ID not Found");
            }

            var Test = new McqTest
            {
                CompanyId = dto.CompanyId,
                Title=dto.Title,
                DurationMinutes=dto.DurationMinutes
            };

            _context.McqTests.Add(Test);
            await _context.SaveChangesAsync();
            return Ok(Test);
        }
        [HttpPost("submit")]
        public async Task<IActionResult> SubmitTest([FromBody] SubmitTestDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var test = await _context.McqTests
                .Include(t => t.Questions)
                    .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(t => t.Id == dto.McqTestId);

            if (test == null)
                return NotFound("MCQ Test not found");

            int score = 0;

            foreach (var answer in dto.Answers)
            {
                if (!int.TryParse(answer.Key, out int questionId))
                    continue; // invalid question id in request

                int selectedOptionId = answer.Value;

                var question = test.Questions.FirstOrDefault(q => q.Id == questionId);
                if (question == null) continue;

                var option = question.Options
                    .FirstOrDefault(o => o.Id == selectedOptionId);

                if (option?.IsCorrect == true)
                    score++;
            }



            var attempt = new CandidateTestAttempt
            {
                McqTestId = dto.McqTestId,
                CandidateEmail = dto.CandidateEmail,
                Score = score,
                SubmittedAt = DateTime.UtcNow
            };

            _context.CandidateTestAttempts.Add(attempt);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                totalQuestions = test.Questions.Count,
                score,
                percentage = (score * 100) / test.Questions.Count
            });
        }
        [HttpGet("company/{companyId}/test/{testId}/questions-with-answers")]
        public async Task<IActionResult> GetQuestionsWithAnswersByCompany(int companyId, int testId)
        {
            // 1. Check company
            bool companyExists = await _context.Companies.AnyAsync(c => c.Id == companyId);
            if (!companyExists)
                return NotFound("Company does not exist");

            // 2. Get test with questions & options
            var test = await _context.McqTests
                .Include(t => t.Questions)
                    .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(t => t.Id == testId && t.CompanyId == companyId);

            // 🔥 IMPORTANT NULL CHECK
            if (test == null)
                return NotFound("Test not found for this company");

            // 3. Response
            var response = new
            {
                test.Id,
                test.Title,
                test.DurationMinutes,
                questions = test.Questions.Select(q => new
                {
                    q.Id,
                    q.QuestionText,
                    options = q.Options.Select(o => new
                    {
                        o.Id,
                        o.OptionText,
                        o.IsCorrect
                    })
                })
            };

            return Ok(response);
        }

    }
}
