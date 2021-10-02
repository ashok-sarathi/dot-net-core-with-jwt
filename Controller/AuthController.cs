using DotNetCoreWithJwt.Helpers;
using DotNetCoreWithJwt.Model;
using DotNetCoreWithJwt.StaticValues;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DotNetCoreWithJwt.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : ControllerBase
    {
        private IJwtAuthHelper _jwtAuthHelper;
        public AuthController(IJwtAuthHelper jwtAuthHelper)
        {
            _jwtAuthHelper = jwtAuthHelper ?? throw new Exception(nameof(IJwtAuthHelper) + " not found!");
        }

        [HttpGet]
        public IList<User> Get()
        {
            return StaticUsers.StaticUsersList;
        }

        [AllowAnonymous]
        [HttpPost]
        public string Login([FromBody] UserDetail userDetail)
        {
            var token = _jwtAuthHelper.Authentication(userDetail);
            if (token == null)
                return "Invalid user name and password";
            return token;
        }
    }
}
