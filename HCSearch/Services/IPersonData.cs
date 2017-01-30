using HCSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Services
{
    public interface IPersonData
    {
        IEnumerable<PersonDto> GetAll();
        IEnumerable<PersonDto> GetByNameFragment(string fragment);
    }
}
