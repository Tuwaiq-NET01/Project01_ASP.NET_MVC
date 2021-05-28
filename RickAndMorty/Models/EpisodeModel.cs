using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickAndMorty.Models
{
    public class EpisodeModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Episode_Code { get; set; }
        public string Air_date { get; set; }
        public string [] Characters { get; set; }
    }
}   
