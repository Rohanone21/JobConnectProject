using AdminService.Data;
using AdminService.DTOs;
using AdminService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly AdminJobDbContext _context;

        public JobApplicationsController(AdminJobDbContext context)
        {
            _context = context;
        }

        [HttpPost("apply")]

        public async Task<IActionResult> ApplyForJob([FromBody] ApplyJobDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var jobExists=await _context.Jobs2.AnyAsync(j=>j.Id==dto.JobId);
            if (!jobExists)
            {
                return NotFound(new { message = "Job Does not Exist" });
            }
            var application = new JobApplication
            {
                JobId=dto.JobId,
                ApplicationName = dto.ApplicationName,
                Email = dto.Email,
                ResumeUrl = dto.ResumeUrl,
                AppliedOn = DateTime.UtcNow,
                MobileNo=dto.MobileNo,
                Address=dto.Address,
                HighestQualification=dto.HighestQualification,
                PhotographUrl=dto.PhotographUrl,
                Skills=dto.Skills,
                LinkedInProfile=dto.LinkedInProfile,
                GitHubProfile=dto.GitHubProfile,
                PortfolioUrl=dto.PortfolioUrl,
                IsWillingToRelocate=dto.IsWillingToRelocate,
                IsShortlisted =dto.IsShortlisted,
                IsApplied=true,

            };
            _context.JobApplications.Add(application);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Job Applied successfully" });
        }

        [HttpGet("job/{jobId}")]

        public async Task<IActionResult> GetApplicationsByJob(int jobId)
        {
            var applications = await _context.JobApplications.Where(a => a.JobId == jobId).Select(a => new
            {
                a.Id,
                a.ApplicationName,
                a.Email,
                a.ResumeUrl,
                a.AppliedOn,
                a.MobileNo,
                a.Address,
                a.HighestQualification,
                a.PhotographUrl,
                a.Skills,
                a.LinkedInProfile,
                a.GitHubProfile,
                a.PortfolioUrl ,        
               a.IsWillingToRelocate,
               a.IsShortlisted,
                a.IsApplied
            }).ToListAsync();
            return Ok(applications);
        }

        [HttpPut("shortlist/{id}")]

        public async Task<IActionResult> ShortlistCandidate(int id)
        {
            var app = _context.JobApplications.Find(id);
            if (app == null)
            {
                return NotFound(new { message = "Data not found" });
            }
            app.IsShortlisted=true;
            await _context.SaveChangesAsync();
            return Ok(app);

        }

        [HttpGet("job/{jobId}/shortlisted")]
        public async Task<IActionResult> GetShortlistedApplicants(int jobId)
        {
            var applicants = _context.JobApplications.Where(x => x.JobId == jobId && x.IsShortlisted).ToList();
            return Ok(applicants);
        }



    }
}
