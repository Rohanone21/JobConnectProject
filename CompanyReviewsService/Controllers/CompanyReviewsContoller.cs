using CompanyReviewsService.Data;
using CompanyReviewsService.DTO_S;
using CompanyReviewsService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyReviewsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyReviewsContoller : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompanyReviewsContoller(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]

        public async Task<IActionResult> AddReview(AddCompanyReviewDto dto)
        {
            var overall= (
                 dto.CompensationBenefits +
                 dto.JobSecurity +
                 dto.CareerGrowth +
                 dto.Management +
                 dto.Culture) / 5.0;

            var review = new CompanyReview
            {
                CompanyId = dto.CompanyId,
                JobTitle = dto.JobTitle,
                EmploymentStatus = dto.EmploymentStatus,
                Location = dto.Location,
                WorkLifeBalance = dto.WorkLifeBalance,
                CompensationBenefits = dto.CompensationBenefits,
                JobSecurity = dto.JobSecurity,
                CareerGrowth = dto.CareerGrowth,
                Management = dto.Management,
                Culture = dto.Culture,
                OverallRating = overall,
                Pros = dto.Pros,
                Cons = dto.Cons,
                AdviceToManagement = dto.AdviceToManagement,
                IsAnonymous = dto.IsAnonymous,
                IsApproved = true

            };

            _context.Add(review);
            await _context.SaveChangesAsync();
            UpdateSummary(dto.CompanyId);
            return Ok(review);
        }

        [HttpGet("company/{companyId}")]

        public async Task<IActionResult> GetCompanyReviews(int companyId)
        {
            var reviews = await  _context.CompanyReviews.Where(r => r.CompanyId == companyId && r.IsApproved).Select(
                r => new CompanyReviewResponseDto
                {
                    JobTitle = r.JobTitle,
                    EmploymentStatus = r.EmploymentStatus,
                    Location = r.Location,
                    OverallRating = r.OverallRating,
                    Pros = r.Pros,
                    Cons = r.Cons,
                    CreatedAt = r.CreatedAt
                }).ToListAsync();
            return Ok(reviews);
        }

        [HttpGet("company/{comapnyId}/summary")]

        public async Task<IActionResult> Summary(int comapnyId)
        {
            var summary = _context.CompanyRatingSummaries.FirstOrDefault(r=>r.CompanyId==comapnyId);
            return Ok(summary);
        }

        private void UpdateSummary(int companyId)
        {
          
            var reviews = _context.CompanyReviews.Where(r => r.CompanyId == companyId & r.IsApproved).ToList();

      
            var summary = _context.CompanyRatingSummaries.FirstOrDefault(r => r.CompanyId == companyId);

            if (summary == null)
            {
                summary = new CompanyRatingSummary { CompanyId = companyId };
                _context.CompanyRatingSummaries.Add(summary);
            }

            summary.TotalReviews = reviews.Count;
            summary.AvgOverallRating = reviews.Average(r => r.OverallRating);
            summary.AvgCompensation = reviews.Average(r => r.CompensationBenefits);
            summary.AvgJobSecurity = reviews.Average(r => r.JobSecurity);
            summary.AvgCareerGrowth = reviews.Average(r => r.CareerGrowth);
            summary.AvgManagement = reviews.Average(r => r.Management);
            summary.AvgCulture = reviews.Average(r => r.Culture);
            summary.LastUpdated = DateTime.UtcNow;

            _context.SaveChanges();
        }


    }

}
