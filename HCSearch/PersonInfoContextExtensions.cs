using HCSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch
{
    public static class PersonInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this PersonInfoContext context)
        {
            if (context.Persons.Any())
            {
                return;
            }

            var persons = new List<Person>()
            {
                new Person
                {
                    Firstname = "Joe",
                    Lastname = "Bob",
                    Address = "123 Main, Erda, UT, 88888",
                    Dob = new DateTime(1961, 7, 23),
                    Interests = new List<Interest>()
                    {
                        new Interest{ Description = "BaseBall" },
                        new Interest{ Description = "Yoga" },
                    }
                },
                new Person
                {
                    Firstname = "Billy",
                    Lastname = "Bob",
                    Address = "123 Main, Erda, UT, 88888",
                    Dob = new DateTime(1976, 7, 4),
                    Interests = new List<Interest>()
                    {
                        new Interest{ Description = "Spitting" },
                        new Interest{ Description = "Mud Wrestling" },
                    }
                },
                new Person
                {
                    Firstname = "Fred",
                    Lastname = "Fargo",
                    Address = "666 Elm Street, Erda, UT, 88888",
                    Dob = new DateTime(1993, 12, 25),
                    Interests = new List<Interest>()
                    {
                        new Interest{ Description = "Reading" },
                        new Interest{ Description = "Traveling" },
                    }
                },
                new Person
                {
                    Firstname = "Forest",
                    Lastname = "Gump",
                    Address = "123 Sunshine Lane, Somewhere, MS, 33333",
                    Dob = new DateTime(2000, 1, 1),
                    Interests = new List<Interest>()
                    {
                        new Interest{ Description = "Running" },
                        new Interest{ Description = "Shrimp" },
                    }
                },
                new Person
                {
                    Firstname = "Harry",
                    Lastname = "Calahan",
                    Address = "357 Magnum Ave., San Francisco, CA, 666666",
                    Dob = new DateTime(1904, 7, 4),
                    Interests = new List<Interest>()
                    {
                        new Interest{ Description = "Guns" },
                        new Interest{ Description = "More Guns" },
                        new Interest{ Description = "Death" },
                    }
                }
            };

            context.Persons.AddRange(persons);

            context.SaveChanges();
        }
    }
}
