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
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(25)]
        public string Lastname { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DateRange("1800/01/01", "2100/01/01")]
        public DateTime Dob { get; set; }
        public virtual ICollection<Interest> Interests { get; set; } = new List<Interest>();
    }
}
