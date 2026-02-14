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
    public class CompaniesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompaniesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var AllCompanies = await _context.Companies.ToListAsync();
            return Ok(AllCompanies);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCompanyDto dto)
        {
            var company = new Company
            {
                Name = dto.Name,
                LogoUrl = dto.LogoUrl,
                Industry = dto.Industry,
                CompanySize = dto.CompanySize,
                Headquarters = dto.Headquarters,
                FoundedYear = dto.FoundedYear,
                Website = dto.Website,
                About = dto.About
            };
            _context.Add(company);
            await _context.SaveChangesAsync();
            return Ok(company);
        }


    }
}
