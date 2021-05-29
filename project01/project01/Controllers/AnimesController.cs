using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project01.Models;

namespace project01.Controllers
{
    public class AnimesController : Controller
    {
        public List<AnimeModel> Anime = new()
        {
            new AnimeModel() { Id = 1, Name = "JoJo no Kimyou na Bouken (TV)", Rate= 8.00,
                Description = "In 1868, Dario Brando saves the life of an English nobleman, George Joestar. By taking in Dario's son Dio when the boy becomes fatherless, George hopes to repay the debt he owes to his savior. However Dio, unsatisfied with his station in life, aspires to seize the Joestar house for his own. Wielding an Aztec stone mask with supernatural properties, he sets out to destroy George and his son, Jonathan \"JoJo\" Joestar, and triggers a chain of events that will continue to echo through the years to come.",
                Type = "Action, Vampire", Image = "https://cdn.myanimelist.net/images/anime/3/40409.jpg"
            },
            new AnimeModel() { Id = 2, Name = "Fumetsu no Anata e", Rate = 8.64, Description = "An Orb, known only as It, is cast to Earth to be observed from afar. Capable of changing forms from beings whose reflections It captures, It first becomes a rock and then, due to the rising temperature, moss. \n It is inept of movement until one snowy day, a wolf at death's door barely crosses by. When It takes the animal's form, It attains awareness of its consciousness and starts to wander with an unclear destination in mind. Soon, It comes across the wolf's master—a young boy waiting for his tribe to return from a paradise abundant with fish and fruit in the south. Although the boy is lonely, he still hopes those whom he holds dear in his memories have not forgotten him and that he will reunite with them one day.",
                Type = "Adventure, Drama", Image = "https://cdn.myanimelist.net/images/anime/1134/111757.jpg" },
            new AnimeModel() { Id = 3, Name = "Akame ga Kill!", Rate = 7.49,
                Description = "Night Raid is the covert assassination branch of the Revolutionary Army, an uprising assembled to overthrow Prime Minister Honest, whose avarice and greed for power has led him to take advantage of the child emperor's inexperience. Without a strong and benevolent leader, the rest of the nation is left to drown in poverty, strife, and ruin. Though the Night Raid members are all experienced killers, they understand that taking lives is far from commendable and that they will likely face retribution as they mercilessly eliminate anyone who stands in the revolution's way.",
                Type = "Action, Drama", Image = "https://cdn.myanimelist.net/images/anime/1429/95946.jpg" },
            new AnimeModel() { Id = 4, Name = "Fullmetal Alchemist: Brotherhood", Rate = 9.17, Description = "Alchemy is bound by this Law of Equivalent Exchange—something the young brothers Edward and Alphonse Elric only realize after attempting human transmutation: the one forbidden act of alchemy. They pay a terrible price for their transgression—Edward loses his left leg, Alphonse his physical body. It is only by the desperate sacrifice of Edward's right arm that he is able to affix Alphonse's soul to a suit of armor. Devastated and alone, it is the hope that they would both eventually return to their original bodies that gives Edward the inspiration to obtain metal limbs called \"automail\" and become a state alchemist, the Fullmetal Alchemist."
                , Type = "Magic, Fantsy", Image = "https://cdn.myanimelist.net/images/anime/1223/96541.jpg" },
            new AnimeModel() { Id = 5, Name = "Jujutsu Kaisen (TV)", Rate = 8.78,
                Description = "Idly indulging in baseless paranormal activities with the Occult Club, high schooler Yuuji Itadori spends his days at either the clubroom or the hospital, where he visits his bedridden grandfather. However, this leisurely lifestyle soon takes a turn for the strange when he unknowingly encounters a cursed item. Triggering a chain of supernatural occurrences, Yuuji finds himself suddenly thrust into the world of Curses—dreadful beings formed from human malice and negativity—after swallowing the said item, revealed to be a finger belonging to the demon Sukuna Ryoumen, the \"King of Curses.\"",
                Type = "Supernaturall, Demon", Image = "https://cdn.myanimelist.net/images/anime/1171/109222.jpg" },
            new AnimeModel() { Id = 6, Name = "Toradora!", Rate = 8.19, Description = "Ryuuji Takasu is a gentle high school student with a love for housework; but in contrast to his kind nature, he has an intimidating face that often gets him labeled as a delinquent. On the other hand is Taiga Aisaka, a small, doll-like student, who is anything but a cute and fragile girl. Equipped with a wooden katana and feisty personality, Taiga is known throughout the school as the \"Palmtop Tiger.\"",
                Type="Romance, Slice of life", Image = "https://cdn.myanimelist.net/images/anime/13/22128.jpg" }
        };
        public IActionResult Index()
        {

            ViewData["AnimeList"] = Anime;
            return View();
        }
        public IActionResult Check(int? id)
        {
            AnimeModel anime = Anime.Find(match: model => model.Id == id);

            if (anime == null)
            {
                return Content("No product with that name");
            }
            else
            {
                ViewData["AnimeList"] = anime;
                return View();
            }
        }
        public IActionResult orderMe(double? rate)
        {
            AnimeModel orderByRate = (AnimeModel)Anime.OrderBy( model => model.Rate == rate);

            if (orderByRate == null)
            {
                return Content("No product with that name");
            }
            else
            {
                ViewData["AnimeList"] = orderByRate;
                return View();
            }
        }
        
    }
}
