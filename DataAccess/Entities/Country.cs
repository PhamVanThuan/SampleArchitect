using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace DataAccess.Entities
{
    [Table("Country")]
    public class Country: Entity<int>
    {
        public virtual IEnumerable<Person> Persons { get; set; }
    }
}
