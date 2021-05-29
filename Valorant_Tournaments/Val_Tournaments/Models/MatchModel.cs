using System;
namespace Val_Tournaments.Models
{
    public class MatchModel
    {
        public int Id { get; set; }
        public int Team1_id { get; set; }
        public int Team2_id { get; set; }
        public int Winner_id { get; set; }
        public DateTime date { get; set; }
        public string type { get; set; }
    }
}
