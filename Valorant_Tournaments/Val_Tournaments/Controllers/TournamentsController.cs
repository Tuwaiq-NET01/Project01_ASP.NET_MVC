using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Val_Tournaments.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Val_Tournaments.Controllers
{
    public class TournamentsController : Controller
    {
        //List<TeamModel> teams = new List<TeamModel>()
        //{
        //    new TeamModel { Id = 1, Name = "Team Liquid", Current_Roster = new string[] { "	Adil \"ScreaM\" Benrlitom", "Elias \"Jamppi\" Olkkonen", "Travis \"L1nk\" Mendoza", "James \"Kryptix\" Affleck", "Dom \"soulcas\" Sulcas"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/Team_Liquid_logo.svg/1200px-Team_Liquid_logo.svg.png" },
        //    new TeamModel { Id = 2, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza","hazed","Braxton" , "Drone"},Region = "North America" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 3, Name = "100T", Current_Roster = new string[] { "Wardell","Subroza","hazed","Braxton" , "Drone"},Region = "North America" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 4, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza","hazed","Braxton" , "Drone"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 5, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza","hazed","Braxton" , "Drone"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 6, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza","hazed","Braxton" , "Drone"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" }
        //};

        //List<MatchModel> t1_matches = new List<MatchModel> {
        //    new MatchModel {Id =1, date = new DateTime(2021, 6, 24), Team1_id = 1, Team2_id = 2 , Winner_id= 1},
        //    new MatchModel {Id =2, date = new DateTime(2021, 6, 24), Team1_id = 3, Team2_id = 4 , Winner_id= 4},
        //    new MatchModel {Id =3, date = new DateTime(2021, 6, 24), Team1_id = 5, Team2_id = 6 , Winner_id= 5},

        //    new MatchModel {Id =4, date = new DateTime(2021, 6, 25), Team1_id = 1, Team2_id = 4 , Winner_id= 5},

        //    new MatchModel {Id =5, date = new DateTime(2021, 6, 26), Team1_id = 5, Team2_id = 4  , Winner_id= 5}
        //};

        //List<TouurnamentModel> tournaments = new List<TouurnamentModel>
        //{
        //     new TouurnamentModel { Id = 1, Name = "Valorant Champions Tour Stage 2: Masters Reykjavik", Start_date = new DateTime(2021, 6, 24), End_date = new DateTime(2021, 6, 30), Region = "Reykjavik, Iceland", Teams = new int[] { 1, 2, 3, 4,5,6 }, Matches = new int[]{1,2,3,4,5}, Winner_id = -1,Logo ="https://owcdn.net/img/603bfd7bf3f54.png" },
        //     new TouurnamentModel { Id = 2, Name = "First Strike: North America", Start_date = new DateTime(2021, 6, 24), End_date = new DateTime(2021, 6, 30), Region = "Reykjavik, Iceland", Teams = new int[] { 1, 2, 3, 4,5,6 }, Matches = new int[]{1,2,3,4,5}, Winner_id = 3 , Logo ="https://owcdn.net/img/5f8e73ec18ba4.png"}
        //};

        // GET: /<controller>/
        public IActionResult Index()
        {
            string api = "https://api.pandascore.co/valorant/series??per_page=2000&token=hJcBZ1XLKGmA5yFSChwcc7Ixr0p4N89_urFG8MhE-WWBY8YWRkc";
            JArray jsonArray = JArray.Parse(httpReq(api));
            List<TouurnamentModel> tourns = new List<TouurnamentModel>();

            foreach (dynamic jObj in jsonArray)
            {
                tourns.Add(new TouurnamentModel { Id = jObj.id, Name = jObj.full_name, Start_date = jObj.begin_at, End_date = jObj.end_at,Logo = jObj.league.image_url, Tier = jObj.tier });
            }
            
            ViewBag.tournaments = tourns;
            return View();
        }

        public IActionResult Details(int id =0)
        {

            string api = String.Format("https://api.pandascore.co/valorant/series?filter[id]={0}&token=hJcBZ1XLKGmA5yFSChwcc7Ixr0p4N89_urFG8MhE-WWBY8YWRkc", id);
            //string api = "https://api.pandascore.co/valorant/series??per_page=2000&token=hJcBZ1XLKGmA5yFSChwcc7Ixr0p4N89_urFG8MhE-WWBY8YWRkc";
            List<TouurnamentModel> tourns = new List<TouurnamentModel>();
            dynamic jsonArray = JArray.Parse(httpReq(api));

            foreach(dynamic jObj in jsonArray )
            {
                tourns.Add(new TouurnamentModel { Id=jObj.id, Name=jObj.full_name, Start_date=jObj.begin_at, End_date= jObj.end_at,Tier = jObj.tier, Logo = jObj.league.image_url });
            }
            /*
             models foreach Jarray{
            [{},
            {}]
            }
             */
            ViewBag.tournaments = tourns[0];
            ViewBag.uri = api;
            return View();
        }

        public string httpReq(string api)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(api);

                var resonse = client.GetAsync(uri);
                resonse.Wait();
                string res = resonse.Result.Content.ReadAsStringAsync().Result;

                return res;
            }
        }
    }

}
