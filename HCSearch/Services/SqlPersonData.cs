using HCSearch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HCSearch.Services
{
    public class SQLPersonData : IPersonData
    {
        private PersonInfoContext _dbContext;
        private int _delay = 0;

        public SQLPersonData(PersonInfoContext dbContext)
        {
            _dbContext = dbContext;
            Int32.TryParse(Startup.Configuration["delayMS"], out _delay);

        }

        public IEnumerable<PersonDto> GetAll()
        {
            //return _dbContext.Persons.Include(p => p.Interests);
            var people = from p in _dbContext.Persons.Include(p => p.Interests)
                         select new PersonDto()
                         {
                             Firstname = p.Firstname,
                             Lastname = p.Lastname,
                             Address = p.Address,
                             Age = p.Dob.Age(),
                             Interests = p.Interests,
                         };

            if (_delay > 0)
            {
                Thread.Sleep(_delay);
            }

            return people;
        }

        public IEnumerable<PersonDto> GetByNameFragment(string fragment)
        {

            //var people = _dbContext.Persons
            //    .Include(p => p.Interests)
            //    .Where(p => p.Firstname.ToUpperInvariant().Contains(fragment.ToUpperInvariant())
            //                                || p.Lastname.ToUpperInvariant().Contains(fragment.ToUpperInvariant()));

            var people = from p in _dbContext.Persons.Include(p => p.Interests)
                         where p.Firstname.ToUpperInvariant().Contains(fragment.ToUpperInvariant())
                         || p.Lastname.ToUpperInvariant().Contains(fragment.ToUpperInvariant())
                         select new PersonDto()
                         {
                             Firstname = p.Firstname,
                             Lastname = p.Lastname,
                             Address = p.Address,
                             Age = p.Dob.Age(),
                             Interests = p.Interests,
                         };

            if (_delay > 0)
            {
                Thread.Sleep(_delay);
            }

            return people;
        }
    }
}
