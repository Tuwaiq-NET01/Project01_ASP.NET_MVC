using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickAndMorty.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public string Species { get; set; }
        public string Origin { get; set; }
        public int Episodes { get; set; } 
    }
}
