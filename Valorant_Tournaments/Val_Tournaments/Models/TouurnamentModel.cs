using System;
namespace Val_Tournaments.Models
{
    public class TouurnamentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Logo { get; set; }
        public string Tier { get; set; }
        public int[] Matches { get; set; }
        public int[] Teams { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public int Winner_id { get; set; }
    }
}
