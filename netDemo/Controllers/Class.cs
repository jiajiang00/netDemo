using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netDemo.Controllers
{
    [Route("[controller]")]
    public class ClassController : Controller
    {
        [HttpGet("index")]
        public string index()
        {
            return Environment.GetEnvironmentVariable("asd");
        }
    }

}

