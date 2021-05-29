using Inventors.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventors.Controllers
{
    public class InventorController : Controller
    {
        List<Inventor> InventorsList = new List<Inventor>() {
            new Inventor {Id=1, Name="Alexander Graham Bell", Nationality="United Kingdom",
                Image ="https://upload.wikimedia.org/wikipedia/commons/1/10/Alexander_Graham_Bell.jpg",
                Field = "", BirthDate = new DateTime(1847, 3, 3), DeathDate = new DateTime(1922, 8, 2), Description="Alexander Graham Bell, best known for his invention of the telephone, revolutionized communication as we know it. His interest in sound technology was deep-rooted and personal, as both his wife and mother were deaf. While there’s some controversy over whether Bell was the true pioneer of the telephone, he secured exclusive rights to the technology and launched the Bell Telephone Company in 1877. Ultimately, the talented scientist held more than 18 patents for his inventions and work in communications."},

            new Inventor {Id=2, Name="Nikola Tesla", Nationality="Austria",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/N.Tesla.JPG/800px-N.Tesla.JPG",
                Field = "", BirthDate = new DateTime(1856, 7, 10), DeathDate = new DateTime(1943, 1, 7), Description="Serbian-American engineer and physicist Nikola Tesla (1856-1943) made dozens of breakthroughs in the production, transmission and application of electric power. He invented the first alternating current (AC) motor and developed AC generation and transmission technology. Though he was famous and respected, he was never able to translate his copious inventions into long-term financial success—unlike his early employer and chief rival, Thomas Edison."},

            new Inventor {Id=3, Name="Melitta Bentz", Nationality="Germany",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Melitta_Bentz.jpg/800px-Melitta_Bentz.jpg",
                Field = "", BirthDate = new DateTime( 1873, 1, 31), DeathDate = new DateTime(1950, 6, 29), Description="Amalie Auguste Melitta Bentz (31 January 1873 – 29 June 1950), born Amalie Auguste Melitta Liebscher, was a German entrepreneur who invented the paper coffee filter brewing system in 1908. She founded the namesake company Melitta, which still operates under family control."},

             new Inventor {Id=4, Name="Karl Benz", Nationality="Germany",
                Image ="https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Carl_Benz.png/800px-Carl_Benz.png",
                Field = "", BirthDate = new DateTime(1844, 11, 25), DeathDate = new DateTime(1929, 4, 4), Description="Karl Benz, in full Karl Friedrich Benz, Karl also spelled Carl, (born November 25, 1844, Karlsruhe, Baden [Germany]—died April 4, 1929, Ladenburg, near Mannheim, Germany), German mechanical engineer who designed and in 1885 built the world's first practical automobile to be powered by an internal-combustion engine."} };


        public IActionResult Index()
        {
            Console.WriteLine(InventorsList[0].BirthDate.Date);
            ViewData["InventorsList"] = InventorsList;
            return View();
        }


        public IActionResult Details(int? id)
        {
            ViewData["Inventor"] = InventorsList.Find(b => b.Id == id);
            if (ViewData["Inventor"] == null)
            {
                return Content("404");
            }
            else
            {
                return View();
            }
        }
    }
}
