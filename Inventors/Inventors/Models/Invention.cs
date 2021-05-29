using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventors.Models
{
    public class Invention
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Image { set; get; }

        [DataType(DataType.Date)]
        public DateTime PatentDate { set; get; }
        public string PatentNumber { set; get; }
        public string Description { set; get; }
    }
}
