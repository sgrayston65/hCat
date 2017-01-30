using HCSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Services
{
    interface ISearch
    {
        IEnumerable<Person> SearchByNameFrag(string frag);
    }
}
