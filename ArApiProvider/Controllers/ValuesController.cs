using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArApiProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [BindProperty(SupportsGet = true)]
        public string Bind { get; set; }
        [HttpGet]
        public  IActionResult Get()
        {
            return Ok("OK " + Bind);
        }
    }
}
