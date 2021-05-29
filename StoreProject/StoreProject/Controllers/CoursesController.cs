using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreProject.Models;

namespace StoreProject.Controllers
{
    public class CoursesController : Controller
    {
        List<CourseModel> course = new List<CourseModel>()
            { new CourseModel(){ CourseId =1 , CourseName="Coal Tea" , CourseLecturer="Abdulaziz Alasmari " , CoursePrice=7.3f , CourseRating="10" , CourseSummary="you will be able to make the best tea on coal possible , UNLESS the Teapot is bigger than 1 liter ... then you are on your own ." , CourseImg = "https://pbs.twimg.com/media/DLDybaTWkAE8VTq?format=jpg&name=medium" },
              new CourseModel(){ CourseId =2 , CourseName="How to bend the rules" , CourseLecturer="Abdulrahman Bin Maneea" , CoursePrice=5.10f , CourseRating= "8.3", CourseSummary="You will be able to take advantage of every loophole in the system and or cheat to make one .But always remember THE END JUSTIFIES THE MEANS" , CourseImg = "https://m9v9r6h3.stackpathcdn.com/wp-content/uploads/2017/07/x-bend-the-rules-2.jpg" },
              new CourseModel(){ CourseId =3 , CourseName="MEME LORD -Sarcasism is an art" , CourseLecturer="Faisal Alsagri" , CoursePrice=10.0f , CourseRating= "9.0", CourseSummary="C'mon ? forreal ? , just take the course and be a MEME Lord with a killer sense of humor" , CourseImg = "https://images-na.ssl-images-amazon.com/images/I/5112QlbhMzL.jpg" },
              new CourseModel(){ CourseId =4 , CourseName="The Sekret to MASTRING the Speling" , CourseLecturer="Hussain Alghamdi" , CoursePrice=12.0f , CourseRating= "10", CourseSummary="You will be a Spelling Bee Champion even if you don't get it" , CourseImg = "https://www.dictionary.com/e/wp-content/uploads/2017/09/Spelling_matters_1000x700.jpg" },
              new CourseModel(){ CourseId =5 , CourseName="How to force your boss To LIKE you" , CourseLecturer="Anas Alhmoud" , CoursePrice=4f , CourseRating= "3", CourseSummary="You will be able to communicate freely with your boss . He most likely will refuse everything you ask for ,But atleast you tried" , CourseImg = "https://i.pinimg.com/originals/83/17/ae/8317ae28852af68fd402dbff6c240838.png" },
              new CourseModel(){ CourseId =6 , CourseName="How to be Professional Baloter" , CourseLecturer="Thamer Mashni" , CoursePrice=12f , CourseRating= "10", CourseSummary="You will be able to play with MESBAH ALDRB" , CourseImg = "https://upload.wikimedia.org/wikipedia/commons/3/30/Belote-exemple9-9.jpg" },
              new CourseModel(){ CourseId =7 , CourseName="Losing weight, is A PIECE OF CAKE" , CourseLecturer="Abdulrahman Aljafar" , CoursePrice=50f , CourseRating= "1.3", CourseSummary="You will be able to gain weight AS SOON AS POSSIBLE" , CourseImg = "https://www.ruralhealthinfo.org/assets/1047-3543/obesity-weight-control-fb.jpg" },
              new CourseModel(){ CourseId =8 , CourseName="Be ALMOST good at Chess" , CourseLecturer="Hassan algadah" , CoursePrice=2.5f , CourseRating= "4.3", CourseSummary="You will be able to escape checkmate in 6 moves" , CourseImg = "https://media.wired.com/photos/5f592bfb643fbe1f6e6807ec/16:9/w_2400,h_1350,c_limit/business_chess_1200074974.jpg" },
              new CourseModel(){ CourseId =9 , CourseName="Poetry encapsulates the beauty of the soul" , CourseLecturer="Mohammed ALHARBI" , CoursePrice=10 , CourseRating= "7.9", CourseSummary="Al Motanabi GOT NOTHING ON YOU" , CourseImg = "https://le-cdn.website-editor.net/fe00667aeec34ca4a337137839af94ce/dms3rep/multi/opt/The%2BPoet%2Bnew%2Blogo-270w.jpg" },
              new CourseModel(){ CourseId =10 , CourseName="The history of ALZOUBI" , CourseLecturer="Sultan alzoubi" , CoursePrice=2.5f , CourseRating= "4", CourseSummary="You won't be able to learn AT ALL" , CourseImg = "https://arielepicsimplehistoryhome.files.wordpress.com/2018/11/history-2.jpg" },
              new CourseModel(){ CourseId =11 , CourseName="Meedah- the REAL QASEEMIAN ACCENT" , CourseLecturer="Meshal Najdi" , CoursePrice=1000000f , CourseRating= "11", CourseSummary="You will Master ALL accents to PERFECTION" , CourseImg = "https://images.squarespace-cdn.com/content/v1/5460c83ce4b08eea0acd5057/1505481902377-QE8HHOG0NXS6BKTTD07P/ke17ZwdGBToddI8pDm48kKxEDrUYOL4PcTsVsdkH9Y17gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1UShVs3-Pce8X6EU21WgtranH7vZ7cbBZz43yvv6LSfFJCFPPrI4Ol6kWijphLg8fRg/image-asset.jpeg" },
              new CourseModel(){ CourseId =12 , CourseName="8 Ball To ROLE Them ALL" , CourseLecturer="Mansour Al Dundur" , CoursePrice=7f , CourseRating= "8 BALL", CourseSummary="You will master the SPIDERMAN billiards grip" , CourseImg = "https://img.joomcdn.net/d3cd1d92f0d23f5f099280f4417cfc6182600cf0_original.jpeg" },

            };
        public IActionResult Index()
        {
            ViewData["courses"] = course;
            return View();
        }

        public IActionResult Details(int? id = 1)
        {

                CourseModel DCourse = course.Find(p => p.CourseId == id);
                if (DCourse == null)
                {
                    return Content("There is no course with this ID ");
                }
                else
                {
                    ViewData["DCourse"] = DCourse;
                    return View();
                }

        }
    }
}
