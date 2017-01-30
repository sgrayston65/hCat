using HCSearch.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Controllers
{
    public class DummyController : Controller
    {
        private PersonInfoContext _ctx;

        public DummyController(PersonInfoContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
