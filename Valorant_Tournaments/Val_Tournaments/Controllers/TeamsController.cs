using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Val_Tournaments.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Val_Tournaments.Controllers
{
    public class TeamsController : Controller
    {
        //List<TeamModel> teams = new List<TeamModel>()
        //{
        //    new TeamModel { Id = 1, Name = "Team Liquid", Current_Roster = new string[] { "	Adil \"ScreaM\" Benrlitom", "Elias \"Jamppi\" Olkkonen", "Travis \"L1nk\" Mendoza", "James \"Kryptix\" Affleck", "Dom \"soulcas\" Sulcas"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/Team_Liquid_logo.svg/1200px-Team_Liquid_logo.svg.png" },
        //    new TeamModel { Id = 2, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza"},Region = "North America" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 3, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza"},Region = "North America" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 4, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza"},Region = "North America" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 5, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" },
        //    new TeamModel { Id = 6, Name = "TSM", Current_Roster = new string[] { "Wardell","Subroza"},Region = "Europe" , Logo= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/TSM_Logo.svg/1200px-TSM_Logo.svg.png" }
        //};

    // GET: /<controller>/
        public IActionResult Index()
        {
            JArray jsonArray = JArray.Parse(httpReq());
            //string data = jsonArray.ToString();
            List<TeamModel>teams = new List<TeamModel>();

            foreach (dynamic jObj in jsonArray)
            {
                List<string> roaster = new List<string>();

                foreach (var plyr in jObj.players)
                {
                    roaster.Add(""+plyr.name);
                }
                teams.Add(new TeamModel { Id = jObj.id, Name = jObj.name, Region = jObj.location,Current_Roster = roaster, Logo = jObj.image_url });
            }

            ViewBag.teams = teams;

            return View();
        }

        public string httpReq()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://api.pandascore.co/valorant/teams?token=hJcBZ1XLKGmA5yFSChwcc7Ixr0p4N89_urFG8MhE-WWBY8YWRkc");
                var resonse = client.GetAsync(uri);
                resonse.Wait();
                string res = resonse.Result.Content.ReadAsStringAsync().Result;

                //res = res.Substring(1, res.Length -2);
                //return res;
                //dynamic jObj = JObject.Parse(res);
                return res;
            }
        }

    }
}
