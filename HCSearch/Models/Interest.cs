using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HCSearch.Models
{
    public class Interest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        //public virtual ICollection<Person> Persons { get; set; } = new List<Person>();
    }
}
