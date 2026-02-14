using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.DTOs;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserJobApplicationsController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public UserJobApplicationsController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("AdminService");
        }

        [HttpPost("apply")]

        public async Task<IActionResult> ApplyJob([FromBody] ApplyJobRequestDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/JobApplications/apply", dto);
            if (!response.IsSuccessStatusCode)
            {
                return BadRequest(await response.Content.ReadAsStringAsync());

            }
            return Ok(new { message = "Job Applied Successfully" });
        }
    }
}
