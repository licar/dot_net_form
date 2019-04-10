using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestServer.Core.Models;
using TestServer.Services;

namespace TestServer.Controllers
{
    [Route("api")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IUserService userService;

        public FormController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Get()
        {
            return Ok(await userService.Get());
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] UserModel user)
        {
            await userService.Add(user);
            return Ok();
        }
    }
}
