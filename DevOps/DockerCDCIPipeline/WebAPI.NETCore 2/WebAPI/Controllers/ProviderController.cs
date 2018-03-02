using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProviderController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id = 11)
        {
            return "value " + id;
        }
    }
}
