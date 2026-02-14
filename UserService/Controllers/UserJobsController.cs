using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserJobsController : ControllerBase
    {
        
        private readonly HttpClient _httpClient;

        public UserJobsController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("AdminService");
        }

      

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            var jobs = await _httpClient.GetFromJsonAsync<List<JobResponseDto>>("api/AdminJobs");
            return Ok(jobs);
        }
       

        [HttpGet("{id}")]
        
        public async Task<IActionResult>GetJobById(int id)
        {
            var jobs =await _httpClient.GetFromJsonAsync<JobResponseDto>($"api/AdminJobs/{id}");
            return Ok(jobs);
        }
    }
}
