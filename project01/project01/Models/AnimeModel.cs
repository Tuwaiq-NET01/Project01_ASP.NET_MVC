using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project01.Models
{
    public class AnimeModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
