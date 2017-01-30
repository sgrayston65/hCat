using HCSearch.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Models
{
    public class PersonDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Interest> Interests { get; set; } = new List<Interest>();
    }
}
