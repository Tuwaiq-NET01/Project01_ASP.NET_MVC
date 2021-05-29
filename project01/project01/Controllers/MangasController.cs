using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project01.Models;

namespace project01.Controllers
{
    public class MangasController : Controller
    {
        public List<MangaModel> Manga = new()
        {
            new MangaModel() { Id = 1, Name = "Berserk", Rate = 9.37,
                Description = "Guts, a former mercenary now known as the \"Black Swordsman,\" is out for revenge. After a tumultuous childhood, he finally finds someone he respects and believes he can trust, only to have everything fall apart when this person takes away everything important to Guts for the purpose of fulfilling his own desires. Now marked for death, Guts becomes condemned to a fate in which he is relentlessly pursued by demonic beings.", 
                Type = "Horror, SuperNatural", Image = "https://cdn.myanimelist.net/images/manga/1/157897.jpg" },
            new MangaModel() { Id = 2, Name = "Fullmetal Alchemist	", Rate = 9.08, Description = "Alchemists are knowledgeable and naturally talented individuals who can manipulate and modify matter due to their art. Yet despite the wide range of possibilities, alchemy is not as all-powerful as most would believe. Human transmutation is strictly forbidden, and whoever attempts it risks severe consequences. Even so, siblings Edward and Alphonse Elric decide to ignore this great taboo and bring their mother back to life. Unfortunately, not only do they fail in resurrecting her, they also pay an extremely high price for their arrogance: Edward loses his left leg and Alphonse his entire body. Furthermore, Edward also gives up his right arm in order to seal his brother's soul into a suit of armor.",
                Type = "Action, Advanture", Image = "https://cdn.myanimelist.net/images/manga/3/243675.jpg" },
            new MangaModel() { Id = 3, Name = "Slam Dunk", Rate = 9.02, Description = "Hanamichi Sakuragi, a tall, boisterous teenager with flame-red hair and physical strength beyond his years, is eager to put an end to his rejection streak of 50 and finally score a girlfriend as he begins his first year of Shohoku High. However, his reputation for delinquency and destructiveness precedes him, and most of his fellow students subsequently avoid him like the plague.",
                Type = "Sport, Comedy", Image = "https://cdn.myanimelist.net/images/manga/2/157904.jpg" },
            new MangaModel() { Id = 4, Name = "GTO: Great Teacher Onizuka", Rate = 8.89, Description = "22-year-old Eikichi Onizuka: pervert, former gang member... and teacher? Great Teacher Onizuka follows the incredible, though often ridiculous,antics of the titular teacher as he attempts to outwit and win over the cunning Class 3 - 4 that is determined to have him removed from the school.However, other obstacles present themselves throughout—including the frustrated,balding vice principal, Hiroshi Uchiyamada; old enemies from his biker days; and his own idiotic teaching methods.But Eikichi fights it all whilst trying to help his students, romance fellow teacher Azusa Fuyutsuki, and earn his self-proclaimed title."
                , Type = "Ecchi, Comedy", Image = "https://cdn.myanimelist.net/images/manga/2/172982.jpg" },
            new MangaModel() { Id = 5, Name = "Solo Leveling", Rate = 8.86,
                Description = "Ten years ago, \"the Gate\" appeared and connected the real world with the realm of magic and monsters. To combat these vile beasts, ordinary people received superhuman powers and became known as \"Hunters.\" Twenty-year-old Sung Jin-Woo is one such Hunter, but he is known as the \"World's Weakest,\" owing to his pathetic power compared to even a measly E-Rank. Still, he hunts monsters tirelessly in low-rank Gates to pay for his mother's medical bills.",
                Type = "Advanture, Fantsy", Image = "https://cdn.myanimelist.net/images/manga/3/222295.jpg"
            },
            new MangaModel() { Id = 6, Name = "One Punch-Man", Rate = 8.73, Description = "After rigorously training for three years, the ordinary Saitama has gained immense strength which allows him to take out anyone and anything with just one punch. He decides to put his new skill to good use by becoming a hero. However, he quickly becomes bored with easily defeating monsters, and wants someone to give him a challenge to bring back the spark of being a hero.",
                Type = "Action, Comedy", Image = "https://cdn.myanimelist.net/images/manga/3/80661.jpg"
            }
        };
        public IActionResult Index()
        {

            ViewData["MangaList"] = Manga;
            return View();
        }
        public IActionResult Check(int? id)
        {
            MangaModel manga = Manga.Find(match: model => model.Id == id);

            if (manga == null)
            {
                return Content("No product with that name");
            }
            else
            {
                ViewData["MangaList"] = manga;
                return View();
            }
        }
    }
}
