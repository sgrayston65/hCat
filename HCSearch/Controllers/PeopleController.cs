using HCSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace HCSearch.Controllers
{
    [Route("api/people")]
    public class PeopleController : Controller
    {
        IPersonData _personData;

        public PeopleController(IPersonData personData)
        {
            _personData = personData;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            return Ok(_personData.GetAll());
        }

        [HttpGet("{fragment}")]
        public IActionResult Search(string fragment)
        {
            return Ok(_personData.GetByNameFragment(fragment));
        }
    }
}
