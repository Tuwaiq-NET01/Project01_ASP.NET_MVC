using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;

namespace GameStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private IList<ProductModel> all;


        private readonly ILogger<ProductsController> _logger;

        public ProductsController()
        {
            this.all = new List<ProductModel>
            {
                new ProductModel
                {
                    Id = 1,
                    Name = "Grand Theft Auto V",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/84d/84da2ac3fdfc6507807a1808595afb12.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{ "https://media.rawg.io/media/games/84d/84da2ac3fdfc6507807a1808595afb12.jpg",
                    "https://media.rawg.io/media/screenshots/a7c/a7c43871a54bed6573a6a429451564ef.jpg",
                    "https://media.rawg.io/media/screenshots/cf4/cf4367daf6a1e33684bf19adb02d16d6.jpg",
                    "https://media.rawg.io/media/screenshots/f95/f9518b1d99210c0cae21fc09e95b4e31.jpg",
                    "https://media.rawg.io/media/screenshots/a5c/a5c95ea539c87d5f538763e16e18fb99.jpg",
                    "https://media.rawg.io/media/screenshots/a7e/a7e990bc574f4d34e03b5926361d1ee7.jpg",
                    "https://media.rawg.io/media/screenshots/592/592e2501d8734b802b2a34fee2df59fa.jpg",
                    }
                },
                new ProductModel
                {
                    Id = 2,
                    Name = "Portal 2",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/328/3283617cb7d75d67257fc58339188742.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                    "https://media.rawg.io/media/games/328/3283617cb7d75d67257fc58339188742.jpg",
                    "https://media.rawg.io/media/screenshots/221/221a03c11e5ff9f765d62f60d4b4cbf5.jpg",
                    "https://media.rawg.io/media/screenshots/173/1737ff43c14f40294011a209b1012875.jpg",
                    "https://media.rawg.io/media/screenshots/b11/b11a2ae0664f0e8a1ef2346f99df26e1.jpg",
                    "https://media.rawg.io/media/screenshots/d05/d058fc7f7fa6128916c311eb14267fed.jpg",
                    "https://media.rawg.io/media/screenshots/415/41543dcc12dffc8e97d85a56ad42cda8.jpg",
                    "https://media.rawg.io/media/screenshots/9b1/9b107a790909b31918ebe2f40547cc85.jpg",
                    }
                },
                new ProductModel
                {
                    Id = 3,
                    Name = "The Witcher 3: Wild Hunt",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/618/618c2031a07bbff6b4f611f10b6bcdbc.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                     "https://media.rawg.io/media/games/618/618c2031a07bbff6b4f611f10b6bcdbc.jpg",
  "https://media.rawg.io/media/screenshots/1ac/1ac19f31974314855ad7be266adeb500.jpg",
  "https://media.rawg.io/media/screenshots/6a0/6a08afca95261a2fe221ea9e01d28762.jpg",
  "https://media.rawg.io/media/screenshots/cdd/cdd31b6b4a687425a87b5ce231ac89d7.jpg",
  "https://media.rawg.io/media/screenshots/862/862397b153221a625922d3bb66337834.jpg",
  "https://media.rawg.io/media/screenshots/166/166787c442a45f52f4f230c33fd7d605.jpg",
  "https://media.rawg.io/media/screenshots/f63/f6373ee614046d81503d63f167181803.jpg"
                    }
                },
                new ProductModel
                {
                    Id = 4,
                    Name = "Tomb Raider (2013)",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/ad2/ad2ffdf80ba993654f31da045bc02456.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                      "https://media.rawg.io/media/games/ad2/ad2ffdf80ba993654f31da045bc02456.jpg",
  "https://media.rawg.io/media/screenshots/4f9/4f9d5efdecfb63cb99f1baa4c0ceb3bf.jpg",
  "https://media.rawg.io/media/screenshots/80f/80f373082b2a74da3f9c3fe2b877dcd0.jpg",
  "https://media.rawg.io/media/screenshots/a87/a8733e877f8fbe45e4a727c22a06aa2e.jpg",
  "https://media.rawg.io/media/screenshots/3f9/3f91678c6805a76419fa4ea3a045a909.jpg",
  "https://media.rawg.io/media/screenshots/417/4170bf07be43a8d8249193883f87f1c1.jpg",
  "https://media.rawg.io/media/screenshots/2a4/2a4250f83ad9e959d8b4ca9376ae34ea.jpg"
                    }
                },
                new ProductModel
                {
                    Id = 5,
                    Name = "The Elder Scrolls V: Skyrim",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/7cf/7cfc9220b401b7a300e409e539c9afd5.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                        "https://media.rawg.io/media/games/7cf/7cfc9220b401b7a300e409e539c9afd5.jpg",
  "https://media.rawg.io/media/screenshots/3bd/3bd2710bd1ffb6664fdea7b83afd067e.jpg",
  "https://media.rawg.io/media/screenshots/d4e/d4e9b13f54748584ccbd6f998094dade.jpg",
  "https://media.rawg.io/media/screenshots/599/59946a630e9c7871003763d63184404a.jpg",
  "https://media.rawg.io/media/screenshots/c5d/c5dad426038d7d12f933eedbeab48ff3.jpg",
  "https://media.rawg.io/media/screenshots/b32/b326fa01c82db82edd41ed299886ee44.jpg",
  "https://media.rawg.io/media/screenshots/091/091e95b49d5a22de036698fc731395a2.jpg"
                    }
                },
                new ProductModel
                {
                    Id = 6,
                    Name = "Left 4 Dead 2",
                    Released = "2013-09-17",
                    Img =  "https://media.rawg.io/media/games/d58/d588947d4286e7b5e0e12e1bea7d9844.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                     "https://media.rawg.io/media/games/d58/d588947d4286e7b5e0e12e1bea7d9844.jpg",
  "https://media.rawg.io/media/screenshots/4c0/4c043fd1a5ff78900483f2e82580fea0.jpg",
  "https://media.rawg.io/media/screenshots/c90/c9071628c238fbc20b366e2413dd8b4a.jpg",
  "https://media.rawg.io/media/screenshots/e29/e293b0f98092b8c0dbe24d66846088bb.jpg",
  "https://media.rawg.io/media/screenshots/168/16867bc76b385eb0fb749e41f7ada93d.jpg",
  "https://media.rawg.io/media/screenshots/fb9/fb917e562f311f48ff8d27632bd29a80.jpg",
  "https://media.rawg.io/media/screenshots/5f2/5f2ca569912add2a211b20ba3f576b97.jpg"
                    }
                },
                new ProductModel
                {
                    Id = 7,
                    Name = "Borderlands 2",
                    Released = "2013-09-17",
                    Img =  "https://media.rawg.io/media/games/588/588c6bdff3d4baf66ec36b1c05b793bf.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                        "https://media.rawg.io/media/games/588/588c6bdff3d4baf66ec36b1c05b793bf.jpg",
  "https://media.rawg.io/media/screenshots/adb/adbbb37113618ee107459cd5c344f2a8.jpg",
  "https://media.rawg.io/media/screenshots/616/61643dd96e936d29eb68cf53b2334e53.jpg",
  "https://media.rawg.io/media/screenshots/864/8644946ba14a03ab69f0766c42a03f80.jpg",
  "https://media.rawg.io/media/screenshots/f87/f87ad2b8f02b56e36c57b25cf8eac042.jpg",
  "https://media.rawg.io/media/screenshots/194/194e0962afa272604300001718a07793.jpg",
  "https://media.rawg.io/media/screenshots/297/29716964351ecd82545f1de3a50dfc4e.jpg"
                    }
                },
                new ProductModel
                {
                    Id = 8,
                    Name = "Portal",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/7fa/7fa0b586293c5861ee32490e953a4996.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                      "https://media.rawg.io/media/games/7fa/7fa0b586293c5861ee32490e953a4996.jpg",
  "https://media.rawg.io/media/screenshots/99e/99e94bd55eb75fa6e75c3dcbb1a570b2.jpg",
  "https://media.rawg.io/media/screenshots/2f0/2f0297a46934d9fa914c626902b1ce20.jpg",
  "https://media.rawg.io/media/screenshots/3b3/3b3713fbca6194dfc4d6e8a8d006d354.jpg",
  "https://media.rawg.io/media/screenshots/c6f/c6f9afc3e4dd51068b22f04acbc6ca99.jpg",
  "https://media.rawg.io/media/screenshots/748/74841207eec76ebc7fc03210168bfb7e.jpg",
  "https://media.rawg.io/media/screenshots/e72/e7256b4caedf099bcb8ebd332f892334.jpg"
                    }
                },
                new ProductModel
                {
                    Id = 9,
                    Name = "BioShock Infinite",
                    Released = "2013-09-17",
                    Img = "https://media.rawg.io/media/games/fc1/fc1307a2774506b5bd65d7e8424664a7.jpg",
                    Rating = "4.48",
                    RatingsCount = "4764",
                    Color = "0f0f0f",
                    ScreenShots = new[]{
                      "https://media.rawg.io/media/games/fc1/fc1307a2774506b5bd65d7e8424664a7.jpg",
  "https://media.rawg.io/media/screenshots/bf0/bf07e2c6d2c888d372917d9ef453c8a4.jpg",
  "https://media.rawg.io/media/screenshots/9d3/9d38833952812ad7888a6dc21699934f.jpg",
  "https://media.rawg.io/media/screenshots/595/59572d257b6797986e4eabcd1ee023fd.jpg",
  "https://media.rawg.io/media/screenshots/f71/f71c23eb76f050d6180490e82d58d799.jpg",
  "https://media.rawg.io/media/screenshots/871/8713411d5332ceb2b4092073a6f5f3f2.jpg",
  "https://media.rawg.io/media/screenshots/985/985b56daa78e0a23133518d4226e9f97.jpg"
                    }
                },
            };
        }

        [HttpGet]
        public IList<ProductModel> Get()
        {
            return all;
        }
        /*public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 3).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/
    }
}
