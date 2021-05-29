using FoodMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodMVC.Controllers
{

        public class RecipeController : Controller
    {
        List<Recipe> recipes = new List<Recipe>()
            {

                new Recipe {id =1, ChefName="Aarón Sanchez", pic="https://m.media-amazon.com/images/M/MV5BMzk5NTg1MTM5M15BMl5BanBnXkFtZTgwNzU3OTE5OTE@._V1_.jpg", dishImage="https://static.wixstatic.com/media/f22774_94d182a9f1d146489ba9c660ca78be26~mv2_d_5732_3821_s_4_2.jpg/v1/fill/w_1297,h_864,al_c,q_90/f22774_94d182a9f1d146489ba9c660ca78be26~mv2_d_5732_3821_s_4_2.webp", country="Mexico", ingredients=@"½ cup (120 ml) pineapple juice

¼ cup (60 ml) orange juice

¼ cup (60 ml) lime juice

¼ cup (60 ml) soy sauce 

¼ cup (50 ml) grapeseed or vegetable oil

1 teaspoon kosher salt

1 teaspoon ground coriander

½ cup (20 g) chopped fresh cilantro, plus more for serving

4 cloves garlic

1 serrano pepper

2-inch (5 cm) piece peeled fresh ginger

Ground black pepper

4 pounds (1.8 kg) chicken wings (24 wings), tips discarded

3 green onions, thinly sliced on a bias

2 tablespoons (20 g) white sesame seeds, toasted

" },
                 new Recipe {id =2, ChefName="Peter Gilmore", pic="https://i.pinimg.com/474x/e3/28/5d/e3285db8fc95066e85efe83bea216e81.jpg", dishImage="https://img.delicious.com.au/cXL6-CkK/w759-h506-cfill/del/2015/10/strawberries-with-lilly-pillies-moscato-granita-and-bush-honey-cream-14984-1.jpg", country="Australia", ingredients=@"1kg strawberries, hulled
2/3 cup (150g) caster sugar
100g fresh or frozen lilly pillies, stones removed
1/2 vanilla bean, split, seeds scraped
MOSCATO GRANITA
1 cup (250ml) moscato
1/4 cup (55g) caster sugar
BUSH HONEY CREAM
1 cup (250ml) double cream
1 1/2 tbs bush flower honey" },
                 new Recipe {id =3, ChefName="Abdurahman Binkasem", pic="https://pbs.twimg.com/media/EL-RSl5WwAExpOg.jpg", dishImage="https://pbs.twimg.com/media/E2Vl6p8WYAIWs5b.jpg",  country="Saudi Araiba", ingredients=@"2 cups (12 ounces) semisweet chocolate chips
3/4 cup (178.5g) heavy cream, room temperature and divided
3 packages (24 ounces) cream cheese, room temperature
1 1/2 cups (300g) granulated sugar
1/4 cup (29.5g) cocoa powder
5 large eggs, room temperature
1 teaspoon vanilla extract

" },
                new Recipe {id =4, ChefName="Mark McEwan", pic="https://d2l4kn3pfhqw69.cloudfront.net/wp-content/uploads/2019/02/foodpro-mcewan-1024x713.jpg", dishImage="https://media.foodnetwork.ca/recipetracker/4622a32e-71f5-4bc5-a283-b38979c0e7ec_Mark%20McEwan's%20Lobster%20Cobb%20Salad.jpg", country="Canada", ingredients=@"1 slab (5oz/150g) top-quality bacon cut into 1/4 (5mm) pieces

3 Tbsp vegetable or olive oil

3 Tbsp garlic butter

4 thin slices of baguette cut diagonally

1 head Boston lettuce

12 sweet cherry tomatoes, halved

¼ red onion, sliced

3 radishes, thinly sliced

1 cup The Best Herb and Garlic Creamy Dressing (recipe below)

1 avocado, cubed

2 hard-boiled eggs, quartered

5 oz Saint Agur or other top-quality blue cheese, crumbled

2 live lobster, about 1 1/4 lb (625g),
cooked and shelled, chilled,
and cut into bite size pieces 
1/4 bunch chives cut into 2 (5cm) lengths"},
                new Recipe {id =5, ChefName="Thomas Keller", pic="https://pyxis.nymag.com/v1/imgs/389/3ad/922ff8c59f83ac2d02575c7b1133e4fc98-22-thomaskeller.rsquare.w700.jpg", dishImage="https://www.saveur.com/app/uploads/2019/03/18/QNO6UFLWI2QL6P5SDABHWJ3HVA-2048x1536.jpg", country="America", ingredients=@"3 tbsp. unsalted butter
10 oz. bulk sweet or hot breakfast sausage, casing removed
1 carrot, cut into 1/4″ dice
1 small yellow onion, cut into 1/4″ dice
1 stalk celery, cut into 1/4″ dice
2 cups turkey or chicken stock
1⁄3 cup olive oil
2 tbsp. roughly chopped parsley, plus more for garnish
2 tbsp. roughly chopped rosemary
2 tbsp. roughly chopped sage
1 (12-oz.) loaf ciabatta bread, cut into 1″ pieces
Kosher salt and freshly ground black pepper, to taste" },
                new Recipe {id =6, ChefName="Giorgio Locatelli", pic="https://pbs.twimg.com/profile_images/837643411167588352/DsDqMHPA_400x400.jpg", dishImage="https://hg-images.condecdn.net/image/9p8rB9bApdK/crop/1020/f/134-1.jpg", country="Italy", ingredients=@"250g unsalted butter
225g caster sugar
2 medium eggs
50g dark chocolate (70 per cent cocoa)
100g cocoa powder
300g amaretti biscuits, crushed
75g dried figs, chopped"},

            };
        public IActionResult Index()
        {
           
            ViewData["recipes"] = recipes;
            return View();
        }
        public ActionResult Details(int? Id)
        {
            Recipe recipesD = recipes.Find(b => b.id == Id);

            if (recipesD == null)
            {
                return Content("The dish is not found");
            }
            else
            {

                ViewData["recipesD"] = recipesD;
                return View();
            }

        }

    }
}
