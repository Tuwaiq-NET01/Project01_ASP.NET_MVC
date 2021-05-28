using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using RickAndMorty.Models;
using Newtonsoft.Json;

namespace RickAndMorty.Controllers
{
    public class CharactersController : Controller
    {
        List<CharacterModel> characters = new List<CharacterModel>
        {
            new CharacterModel()
            {
                Id = 1,
                Name = "Rick Sanchez",
                Status = "Alive",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (C-137)",
                Image = "https://rickandmortyapi.com/api/character/avatar/1.jpeg",
                Episodes = 41
            },
            new CharacterModel()
            {
                Id = 2,
                Name = "Morty Smith",
                Status = "Alive",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (C-137)",
                Image = "https://rickandmortyapi.com/api/character/avatar/2.jpeg",
                Episodes = 41
            },
            new CharacterModel()
            {
                Id = 3,
                Name = "Summer Smith",
                Status = "Alive",
                Gender="Female",
                Species = "Human",
                Origin = "Earth (Replacement Dimension)",
                Image = "https://rickandmortyapi.com/api/character/avatar/3.jpeg",
                Episodes = 41
            },
            new CharacterModel()
            {
                Id = 4,
                Name = "Beth Smith",
                Status = "Alive",
                Gender="Female",
                Species = "Human",
                Origin = "Earth (Replacement Dimension)",
                Image = "https://rickandmortyapi.com/api/character/avatar/4.jpeg",
                Episodes = 41
            },
            new CharacterModel()
            {
                Id = 5,
                Name = "Jerry Smith",
                Status = "Alive",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (Replacement Dimension)",
                Image = "https://rickandmortyapi.com/api/character/avatar/5.jpeg",
                Episodes = 41
            },
            new CharacterModel()
            {
                Id = 6,
                Name = "Abadango Cluster Princess",
                Status = "Alive",
                Gender="Female",
                Species = "Alien",
                Origin = "Abadango",
                Image = "https://rickandmortyapi.com/api/character/avatar/6.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 7,
                Name = "Abradolf Lincler",
                Status = "Unknown",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (Replacement Dimension)",
                Image = "https://rickandmortyapi.com/api/character/avatar/7.jpeg",
                Episodes = 2
            },
            new CharacterModel()
            {
                Id = 8,
                Name = "Adjudicator Rick",
                Status = "Dead",
                Gender="Male",
                Species = "Human",
                Origin = "unknown",
                Image = "https://rickandmortyapi.com/api/character/avatar/8.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 9,
                Name = "Agency Director",
                Status = "Dead",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (Replacement Dimension)",
                Image = "https://rickandmortyapi.com/api/character/avatar/9.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 10,
                Name = "Alan Rails",
                Status = "Dead",
                Gender="Male",
                Species = "Human",
                Origin = "unknown",
                Image = "https://rickandmortyapi.com/api/character/avatar/10.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 11,
                Name = "Albert Einstein",
                Status = "Dead",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (C-137)",
                Image = "https://rickandmortyapi.com/api/character/avatar/11.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 12,
                Name = "Alexander",
                Status = "Dead",
                Gender="Male",
                Species = "Human",
                Origin = "Earth (C-137)",
                Image = "https://rickandmortyapi.com/api/character/avatar/12.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 13,
                Name = "Alien Googah",
                Status = "Unknown",
                Gender="Unknown",
                Species = "Alien",
                Origin = "Unknown",
                Image = "https://rickandmortyapi.com/api/character/avatar/13.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 14,
                Name = "Alien Morty",
                Status = "Unknown",
                Gender="Male",
                Species = "Alien",
                Origin = "Unknown",
                Image = "https://rickandmortyapi.com/api/character/avatar/14.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 15,
                Name = "Alien Rick",
                Status = "Unknown",
                Gender="Male",
                Species = "Alien",
                Origin = "Unknown",
                Image = "https://rickandmortyapi.com/api/character/avatar/15.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 16,
                Name = "Amish Cyborg",
                Status = "Unknown",
                Gender="Male",
                Species = "Alien",
                Origin = "Unknown",
                Image = "https://rickandmortyapi.com/api/character/avatar/16.jpeg",
                Episodes = 1
            },
            new CharacterModel()
            {
                Id = 17,
                Name = "Annie",
                Status = "Alive",
                Gender="Female",
                Species = "Human",
                Origin = "Earth (C-137)",
                Image = "https://rickandmortyapi.com/api/character/avatar/17.jpeg",
                Episodes = 1
            },

        };
        public IActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
                //HTTP GET
                var responseTask = client.GetAsync("character");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync().Result;
                    var info = JsonConvert.DeserializeObject<Dictionary<string, object>>(readTask);
                    Debug.WriteLine(info.ElementAt(1));
                }
                else //web api sent error response 
                {
                    //log response status here..

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            ViewBag.Characters = characters;
            return View();
        }

        public IActionResult Info(int id)
        {
            CharacterModel character = characters.FirstOrDefault(c => c.Id == id);
            ViewBag.Character = character;
            return character!=null?  View() : Content("Not Found");  
        }
    }
}
