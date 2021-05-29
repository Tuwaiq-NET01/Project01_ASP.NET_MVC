using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project01.Models
{
    public class MangaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
