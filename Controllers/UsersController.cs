using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsTest.Helpers;
using CommandsTest.Models;
using CommandsTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace CommandsTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // POST: users/authenticate
        // Example Request:
        //{
        //    "username": "demo",
        //    "password": "demo"
        //}
        //
        // Example Response:
        //{
        //    "id": 1,
        //    "username": "demo",
        //    "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYmYiOjE2MjY3ODA3NDgsImV4cCI6MTYyNzM4NTU0OCwiaWF0IjoxNjI2NzgwNzQ4fQ.g00roCKQ8zGni5eLlVQ_toiOs9UC8dwH7upwtOdzvpQ"
        //}
        // "token" field is our JWT token.
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
            {
                return BadRequest(new
                {
                    message = "Username or password is incorrect"
                });
            }

            return Ok(response);
        }
    }
}
