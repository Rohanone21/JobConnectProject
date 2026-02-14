using AdminService.Data;
using AdminService.DTOs;
using AdminService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminJobsController : ControllerBase
    {
       private readonly AdminJobDbContext _Context;

        public AdminJobsController(AdminJobDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
     public async Task <IActionResult> GetAllJobs()
        {
            var jobs =await  _Context.Jobs2.OrderByDescending(p => p.postedDate).ToListAsync();
            return Ok(jobs);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobById(int id)
        {
            var jobs=await _Context.Jobs2.FindAsync(id);

            if (jobs == null)
            {
                return NotFound(new {message="Job Not Found"});
            }
            return Ok(jobs);
        }

        [HttpPost]

        public async Task<IActionResult> CreateJob([FromBody] CreateJobDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            var job = new Job
            {
                Title = dto.Title,
                CompanyLogo=dto.CompanyLogo,
                Company = dto.Company,
                Description = dto.Description,
                Location = dto.Location,
                Salary = (decimal)dto.Salary,

            };

            _Context.Jobs2.Add(job);
            await _Context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetJobById), new { id = job.Id }, job);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, [FromBody] CreateJobDto dto)
        {
           

            var job = _Context.Jobs2.Find(id);
            if (job == null)
            {
                return NotFound(new { message = "ID Not Found" });
            }

            if (dto.Title != null)

                if (dto.Title != null)
                    job.Title = dto.Title;

            if (dto.Company != null)
                job.Company = dto.Company;

            if (dto.CompanyLogo != null)
                job.CompanyLogo = dto.CompanyLogo;

            if (dto.Description != null)
                job.Description = dto.Description;

            if (dto.Location != null)
                job.Location = dto.Location;

            if (dto.Salary.HasValue)
                job.Salary = dto.Salary.Value;

            await _Context.SaveChangesAsync();
            return Ok(job);

        }


        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteJob(int id)
        {

            var job =  _Context.Jobs2.Find(id);
            if (job == null)
            {
                return NotFound(new {message="ID not found" });
            }
            _Context.Jobs2.Remove(job);
            await _Context.SaveChangesAsync();
            return NoContent();
        }


    }
}
