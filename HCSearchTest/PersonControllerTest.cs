using HCSearch.Controllers;
using HCSearch.Models;
using HCSearch.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HCSearchTest
{
    public class PersonControllerTest
    {
        PeopleController controller = new PeopleController(new InMemoryPersonData());
        IEnumerable<PersonDto> everyone;

        public PersonControllerTest()
        {
            everyone = ((ObjectResult)controller.GetAll()).Value as IEnumerable<PersonDto>;
        }
        
        [Fact]
        public void GetAllPeopleTest()
        {
            Assert.Equal(3, everyone.Count());
        }

        [Fact]
        public void GetOneSearchTest()
        {
            var one = ((ObjectResult)controller.Search("Joe")).Value as IEnumerable<PersonDto>;
            Assert.Equal(1, one.Count());
        }
    }
}
