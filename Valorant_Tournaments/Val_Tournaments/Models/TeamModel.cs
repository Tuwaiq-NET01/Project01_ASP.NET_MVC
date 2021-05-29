using System;
using System.Collections.Generic;

namespace Val_Tournaments.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Current_Roster { get; set; }
        public string Region { get; set; }
        public string Logo { get; set; }
    }
}
