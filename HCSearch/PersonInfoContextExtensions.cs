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

            List<Person> persons = new List<Person>();
            persons.Add(new Person(
                    "Joe","Bob", "123 Main, Erda, UT, 88888", new DateTime(1993, 12, 25),
                    new List<Interest>()
                    {
                        new Interest{ Description = "Reading" },
                        new Interest{ Description = "Traveling" },
                    }
                        ));
            persons.Add(new Person(
                    "Fred", "Fargo", "666 Elm Street, Erda, UT, 88888", new DateTime(1976, 7, 4),
                    new List<Interest>()
                    {
                        new Interest{ Description = "Spitting" },
                        new Interest{ Description = "Mud Wrestling" },
                    }
                        ));
            persons.Add(new Person(
                    "Billy", "Bob", "123 Main, Erda, UT, 88888", new DateTime(1976, 7, 4),
                    new List<Interest>()
                    {
                        new Interest{ Description = "Spitting" },
                        new Interest{ Description = "Mud Wrestling" },
                    }
                        ));
            persons.Add(new Person(
                    "Forest", "Gump", "123 Sunshine Lane, Somewhere, MS, 33333", new DateTime(2000, 1, 1),
                    new List<Interest>()
                    {
                        new Interest{ Description = "Running" },
                        new Interest{ Description = "Shrimp" },
                    }
                        ));
            persons.Add(new Person(
                    "Harry", "Calahan", "357 Magnum Ave., San Francisco, CA, 666666", new DateTime(1904, 7, 4),
                    new List<Interest>()
                    {
                        new Interest{ Description = "Guns" },
                        new Interest{ Description = "More Guns" },
                    }
                )
            );
            //        }
            //    },
            //    new Person
            //    {
            //        Firstname = "Billy",
            //        Lastname = "Bob",
            //        Address = "123 Main, Erda, UT, 88888",
            //        Dob = new DateTime(1976, 7, 4),
            //        Interests = new List<Interest>()
            //        {
            //            new Interest{ Description = "Spitting" },
            //            new Interest{ Description = "Mud Wrestling" },
            //        }
            //    },
            //    new Person
            //    {
            //        Firstname = "Fred",
            //        Lastname = "Fargo",
            //        Address = "666 Elm Street, Erda, UT, 88888",
            //        Dob = new DateTime(1993, 12, 25),
            //        Interests = new List<Interest>()
            //        {
            //            new Interest{ Description = "Reading" },
            //            new Interest{ Description = "Traveling" },
            //        }
            //    },
            //    new Person
            //    {
            //        Firstname = "Forest",
            //        Lastname = "Gump",
            //        Address = "123 Sunshine Lane, Somewhere, MS, 33333",
            //        Dob = new DateTime(2000, 1, 1),
            //        Interests = new List<Interest>()
            //        {
            //            new Interest{ Description = "Running" },
            //            new Interest{ Description = "Shrimp" },
            //        }
            //    },
            //    new Person
            //    {
            //        Firstname = "Harry",
            //        Lastname = "Calahan",
            //        Address = "357 Magnum Ave., San Francisco, CA, 666666",
            //        Dob = new DateTime(1904, 7, 4),
            //        Interests = new List<Interest>()
            //        {
            //            new Interest{ Description = "Guns" },
            //            new Interest{ Description = "More Guns" },
            //            new Interest{ Description = "Death" },
            //        }
            //    }
            //};

            context.Persons.AddRange(persons);

            context.SaveChanges();
        }
    }
}
