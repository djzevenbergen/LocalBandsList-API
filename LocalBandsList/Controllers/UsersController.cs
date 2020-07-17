using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LocalBandsList.Services;
using LocalBandsList.Models;
using System;

namespace LocalBandsList.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {

    private LocalBandsListContext _db;
    private IUserService _userService;

    public UsersController(LocalBandsListContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody] User userParam)
    {
      Console.WriteLine($"====Console Attempt: {userParam.Username}, {userParam.Password}");
      var user = _userService.Authenticate(userParam.Username, userParam.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect" });
      }
      return Ok(user);
    }

    [AllowAnonymous]
    [HttpPost("create")]
    public void Create([FromBody] User user)
    {
      _db.Users.Add(user);
      _db.SaveChanges();
    }


    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _userService.GetAll();
      return Ok(users);
    }
  }
}