using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWorldWebAPIDocker.Controllers
{
    [Route("api/[controller]")]
    public class ContainerContextController : Controller
    {
        // GET api/ContainerContext
        [HttpGet]
        public dynamic Get()
        {
            return new
            {
                Node = Environment.MachineName
            };
        }

    }
}

