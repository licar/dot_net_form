using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestServer.Core.Models;

namespace TestServer.Controllers
{
    [Route("api")]
    [ApiController]
    public class FormController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<FormModel>> Get()
        {

            return null;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] FormModel form)
        {
            return "value";
        }
    }
}
