using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }   

        [HttpGet("getclaimsbyuser")]
        public IActionResult GetClaimsByUser(User user)
        {
            var result = _userService.GetClaims(user);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getuserbyemail")]
        public IActionResult GetUserByEmail(string email)
        {
            var result = _userService.GetByMail(email);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
