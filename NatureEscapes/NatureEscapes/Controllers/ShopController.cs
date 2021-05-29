using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NatureEscapes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NatureEscapes.Controllers
{
    public class ShopController : Controller
    {
        List<ProductModel> products = new List<ProductModel>
        {
        new ProductModel() {ID = 1,
            Name = "Pink Sugar",
            Price=7.85f,
            Image="https://i.etsystatic.com/6858321/r/il/dc0d70/2801942223/il_1588xN.2801942223_b5m6.jpg",
            Description ="Awake your sense while lavishing your body with this invigorating scented soap bar. Our Pink Sugar soap is scented of a mixture of a stylish, but playful, fruity blend of cotton candy, caramel, vanilla, stawberry, fig leaf, plums, mandarin, lemon drops and raspberry. Ending with soft musk and woods at the base. which is hard to beat.",
            Size=5.5f },
         new ProductModel() {ID = 2,
            Name = "PEPPERMINT",
            Price=8.55f,
            Image="https://i.etsystatic.com/6858321/r/il/f924dd/2657741686/il_1588xN.2657741686_b0un.jpg",
            Description = "Awake your sense while lavishing your body with this invigorating scented soap bar. Our Peppermint soap is scented of a mixture of freshly crushed peppermint which is hard to beat. A perfect clean gentle scent that everyone will love! Our natural cold processed soap is formulated from organic oils of olive, coconut, palm, grape seed, avocado, castor, along with fresh goat’s milk to soothe and nourish even the most delicate skin.",
            Size=5.5f },
         new ProductModel() {
            ID = 3,
            Name = "KENTUCKY BONFIRE",
            Price=8.55f,
            Image = "https://i.etsystatic.com/6858321/r/il/385c6f/2570341898/il_1588xN.2570341898_j4r0.jpg",
            Description = "Our Kentucky Bonfire soap is a warm fragrance blend of orange, bergamot, clove, midnight orchid, musk, leather, oak cask, patchouli and cedar. It's truly a wonderful scent a perfect balance of warm, sweet and musky all in one. Our natural cold processed soap is formulated from organic oils of olive, coconut, palm, grape seed, avocado, castor and raw goat milk to soothe and nourish even the most delicate skin.",
            Size=5.5f },
          new ProductModel()
          {
              ID= 4,
              Name = "Luv-U-Alatte",
              Price = 7.85f,
              Image = "https://i.etsystatic.com/6858321/r/il/da9516/3142543077/il_1588xN.3142543077_gpjg.jpg",
              Description = "Our Luv-U-Alatte soap is scented of deep rich expresso! The perfect steaming cup of coffee! The best soap you can gift the coffee lover in your life! Our natural cold processed soap is formulated from organic oils of olive, coconut, palm, grape seed, avocado, castor, along with fresh goat’s milk to soothe and nourish even the most delicate skin. Infused with organic shea, cocoa butter. The fresh goat milk used in our products comes from our very own goats to help insure the best quality ingredients!",
              Size = 5.5f
          },
          new ProductModel()
          {
              ID= 5,
              Name = "Apple Sage",
              Price = 7.85f,
              Image = "https://i.etsystatic.com/6858321/r/il/044fce/3019318739/il_1588xN.3019318739_bjjw.jpg",
              Description = "Awake your sense while lavishing your body with this invigorating scented soap bar. Our Apple Sage soap is scented of notes of apple, sage, pineapple, and coconut water. which is hard to beat. A perfect clean gentle scent that everyone will love!",
              Size = 5.5f
          },
          new ProductModel()
          {
              ID= 6,
              Name = "Green Tea Cucumber",
              Price = 7.85f,
              Image = "https://i.etsystatic.com/6858321/r/il/c981e6/3045863009/il_1588xN.3045863009_dmla.jpg",
              Description = "Awake your sense while lavishing your body with this invigorating scented soap bar. Our Green Tea Cucumber soap is scented of a mixture of freshly-steeped green tea and crisp cucumber which is hard to beat. A perfect clean gentle scent that everyone will love!",
              Size = 5.5f
                              },
        new ProductModel()
          {
              ID= 7,
              Name = "Sweet Orange",
              Price = 8.75f,
              Image = "https://i.etsystatic.com/6858321/r/il/7ef9f8/2208133630/il_1588xN.2208133630_nrn3.jpg",
              Description = "Uplift and energize your spirit while lavishing your body with this sweet orange calendula soap. It not only lathers up like a dream, but it's scent reminds you of a citrus sunrise! Our organic calendula orange soap is formulated from organic oils of olive, palm, coconut, sweet almond, avocado, castor and raw goat milk to soothe and nourish even the most delicate skin.",
              Size = 5.5f
          },
        new ProductModel()
        {
            ID = 8,
            Name = "Lavender",
            Price = 8.55f,
            Image = "https://i.etsystatic.com/6858321/r/il/6cc506/2677899415/il_1588xN.2677899415_5pn9.jpg",
            Description = "Soothe, relax and rejuvenate your mind while exfoliating, nourishing and cleansing your skin with our handmade organic exfoliating lavender milk soap. All our soap is made with the highest quality ingredients. It’s creamy, rich, makes a luxurious lather that deep cleans and nourishes your skin, and it’s 100% organic.",
            Size = 5.5f
        },
        new ProductModel()
        {
            ID = 9,
            Name = "Fairy Tale Rose",
            Price = 5.55f,
            Image = "https://i.etsystatic.com/6858321/r/il/acf6dd/2858348953/il_1588xN.2858348953_7jeh.jpg",
            Description = "Awake your sense while lavishing your body with this invigorating scented soap bar. Our Fairy Tale Rose soap isn’t your typical take on rose! It has notes of geranium, rose, raspberry, plum, and gardenia. Sandalwood, musk, wood, patchouli, and vanilla add depth and complexity. This scent is simply incredible & will BLOW YOU AWAY!!",
            Size = 3.5f
        },
        new ProductModel()
        {
            ID = 10,
            Name = "Summer Garden",
            Price = 7.55f,
            Image = "https://i.etsystatic.com/6858321/r/il/a33fca/2556244858/il_1588xN.2556244858_rcsy.jpg",
            Description = "Awake your spirit and sense while lavishing your body with this invigorating soap. It not only lathers up like a dream, but it's scent reminds you of a summer garden filled with lush greenery and aroma filled flowers. It’s fresh and earthy fragrance has a complexity that will keep you coming back for more. At first you notice the top notes of rosehip, jasmine, sweet basil, peppermint leaf, and flower buds. Then notes of thyme, palm leaves, woods, amber, marigold, and violet come through.",
            Size = 5.5f
        }
        };
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["products"] = products;
            return View();
        }

        public IActionResult Details(int? id)
        {
            ProductModel p = products.Find(x => x.ID == id);
            if(p == null)
            {
                return Content("Not found");
            } else
            {
                ViewData["product"] = p;
            }
            return View();
        }
    }
}
