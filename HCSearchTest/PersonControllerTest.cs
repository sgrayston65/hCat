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
        public void GetOneSearchTestForJoe_Bob()
        {
            var one = ((ObjectResult)controller.Search("Joe Bob")).Value as IEnumerable<PersonDto>;
            Assert.Equal(1, one.Count());
        }

        [Fact]
        public void GetOneSearchTestForJoeBob()
        {
            var one = ((ObjectResult)controller.Search("JoeBob")).Value as IEnumerable<PersonDto>;
            Assert.Equal(1, one.Count());
        }

        [Fact]
        public void GetOneSearchTestForJoe()
        {
            var one = ((ObjectResult)controller.Search("Joe")).Value as IEnumerable<PersonDto>;
            Assert.Equal(1, one.Count());
        }

        [Fact]
        public void GetOneSearchTestForBob()
        {
            var one = ((ObjectResult)controller.Search("Bob")).Value as IEnumerable<PersonDto>;
            Assert.Equal(2, one.Count());
        }
    }
}
