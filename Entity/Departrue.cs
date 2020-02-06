using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Test.WebUI.Entity
{
    public class Departrue
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
