using HCSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Services
{
    public class InMemoryPersonData : IPersonData
    {
        List<PersonDto> _persons;

        public InMemoryPersonData()
        {
            _persons = new List<PersonDto>
            {
                new PersonDto
                {
                    Firstname = "Joe",
                    Lastname = "Bob",
                    Address = "123 Main, Erda, UT, 88888",
                    Age = 20,
                    Interests = new List<Interest>()
                    {
                        new Interest{ Id = 1, Description = "BaseBall" },
                        new Interest{ Id = 2,  Description = "Yoga" },
                    }
                },
                new PersonDto
                {
                    Firstname = "Billy",
                    Lastname = "Bob",
                    Address = "123 Main, Erda, UT, 88888",
                    Age = 20,
                    Interests = new List<Interest>()
                    {
                        new Interest{ Id = 3,  Description = "Spitting" },
                        new Interest{ Id = 4,  Description = "Mud Wrestling" },
                    }
                },
                new PersonDto
                {
                    Firstname = "Fred",
                    Lastname = "Fargo",
                    Address = "666 Elm Street, Erda, UT, 88888",
                    Age = 40,
                    Interests = new List<Interest>()
                    {
                        new Interest{ Id = 5,  Description = "Reading" },
                        new Interest{ Id = 6,  Description = "Traveling" },
                    }
                }
            };
        }

        public IEnumerable<PersonDto> GetAll()
        {
            return _persons;
        }

        public IEnumerable<PersonDto> GetByNameFragment(string fragment)
        {
            return _persons.FindAll(p => p.Firstname.ToUpperInvariant().Contains(fragment.ToUpperInvariant()) 
                                        || p.Lastname.ToUpperInvariant().Contains(fragment.ToUpperInvariant()));
        }
    }
}
