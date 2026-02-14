using JwtAuthOne.Entities;
using JwtAuthOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase

    {
        public static User user = new();
        [HttpPost("register")]

        public ActionResult<User> Register(UserDto request)
        {
            var hashedPassword=new PasswordHasher<User>().HashPassword(user,request.Password);

            user.Username=request.UserName;
            user.PasswordHash = hashedPassword;

            return Ok(user);

        }

    }
}
