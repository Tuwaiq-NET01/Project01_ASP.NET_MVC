using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventors.Models
{
    public class Inventor
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Nationality { set; get; }
        public string Image { set; get; }
        public string Field { set; get; }
        
        [DataType(DataType.Date)]
        public DateTime BirthDate { set; get; }

        [DataType(DataType.Date)]
        public DateTime DeathDate { set; get; }
    }
}
