using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreProject.Models;

namespace StoreProject.Controllers
{
    public class LecturersController : Controller
    {
        List<LecturerModel> lecturer = new List<LecturerModel>()
            { new LecturerModel(){ LecturerId=1, LecturerName="Abdulaziz Alasmri", LecturerCourse= 1, LecturerSummary="Great coal tea specialist and knows a little bit in philosophy .Knows all about SHAVING", LecturerRating="10", LecturerPrice=70f, LecturerImg = "http://t0.gstatic.com/licensed-image?q=tbn:ANd9GcTL7mM-4xIusFwBanyvvG9gbE1TbjWqPB82cLpQgzlJpzVv8ommngwZtCHmYANJ" },
             new LecturerModel(){ LecturerId=2, LecturerName="Abdulrahman Bin Maneea", LecturerCourse= 2, LecturerSummary="Very tricky .. There is no law or code he CANT get Around . THE PREMIUM TUWAIQ PRODUCT . ", LecturerRating="9.99", LecturerPrice=56f, LecturerImg = "https://image.shutterstock.com/image-photo/hacking-malware-concept-hacker-using-600w-1198362232.jpg" },
             new LecturerModel(){ LecturerId=3, LecturerName="Faisal Alsagri", LecturerCourse= 3, LecturerSummary="There is NO situation he cant find a MEME for , REACT specialist and JS lover.Sometimes be hard on other Lecturers ", LecturerRating="9.2", LecturerPrice=59.99f, LecturerImg = "https://i.ibb.co/QJ4zGPK/IMG-9209.jpg" },
             new LecturerModel(){ LecturerId=4, LecturerName="Hussain Alghamdi", LecturerCourse= 4, LecturerSummary="THE COMPLETE PACKAGE , SQL,OUD and COFFIE SPECIALIST.He also can spread Corona ", LecturerRating="10", LecturerPrice=69.99f, LecturerImg = "https://image.shutterstock.com/image-photo/traditional-instrument-middle-east-asia-260nw-1251045772.jpg" },
             new LecturerModel(){ LecturerId=5, LecturerName="Anas Alhmoud", LecturerCourse= 5, LecturerSummary="Leader of the opposition party , QASEEMIAN ACCENT DICTIONARY and a Russian HACKER .", LecturerRating="10", LecturerPrice=49f, LecturerImg = "https://specials-images.forbesimg.com/imageserve/954718112/960x0.jpg?fit=scale" },
             new LecturerModel(){ LecturerId=6, LecturerName="Thamer Mashni", LecturerCourse= 6, LecturerSummary="IF there is anything you don't know , THAMER DOES . PROBLEM SOLVER and valuable member of the gym club", LecturerRating="8", LecturerPrice=69.99f, LecturerImg = "https://saudigazette.com.sa/uploads/images/2018/04/04/788425.jpg" },
             new LecturerModel(){ LecturerId=7, LecturerName="Abdulrahman Aljafar", LecturerCourse= 7, LecturerSummary="IF AND FOR STATEMENTS SPECIALIST ,Baloot enthusiast . His best Qoute is هجت بنآ", LecturerRating="8.4", LecturerPrice=60f, LecturerImg = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTMC04VmDhLcoWiLvS78ZhdGJU50vPZ_lAU3Q&usqp=CAU" },
             new LecturerModel(){ LecturerId=8, LecturerName="Hassan algadah", LecturerCourse= 8, LecturerSummary="The only reason Tuwaiq students were able to get out of their rooms during Quarantine. Can cry like no other ", LecturerRating="10", LecturerPrice=49f, LecturerImg = "https://i.guim.co.uk/img/media/6b63ab55f6a583fc70ad661c2fca52ca4badd1d7/0_188_5472_3283/master/5472.jpg?width=620&quality=45&auto=format&fit=max&dpr=2&s=5dfe1d50d6670868593ce679bf54c00a" },
             new LecturerModel(){ LecturerId=9, LecturerName="Mohammed ALHARBI", LecturerCourse= 9, LecturerSummary="Poet by nature , Has an eye for talented people and coffie specialist ", LecturerRating="7.9", LecturerPrice=69.99f, LecturerImg = "https://22arabi.com/wp-content/uploads/2020/01/%D8%A7%D9%85%D8%B1%D8%A4-%D8%A7%D9%84%D9%82%D9%8A%D8%B3-780x470.png.webp" },
             new LecturerModel(){ LecturerId=10, LecturerName="Sultan alzoubi", LecturerCourse= 10, LecturerSummary="Beloved by everybody. Claims to be a historian but can't 'cut to the point'", LecturerRating="8.9", LecturerPrice=60f, LecturerImg = "https://i.pinimg.com/originals/47/5b/55/475b55b240bc23d6c5a93386b4e0ad75.jpg" },
             new LecturerModel(){ LecturerId=11, LecturerName="Meshal Najdi", LecturerCourse= 11, LecturerSummary="SITE OWNER , THE RULER OF THEM ALL ", LecturerRating="15", LecturerPrice=1000000f, LecturerImg = "https://image.shutterstock.com/image-photo/lifetime-12-inch-ruler-260nw-545801860.jpg" },
             new LecturerModel(){ LecturerId=12, LecturerName="Mansour Al Dundur", LecturerCourse= 12, LecturerSummary="The final Boss in Billiards .Some people think he is bad at Designer but that's a rumor as far as I know.", LecturerRating="9.2", LecturerPrice=51f, LecturerImg = "https://cdn.stocksnap.io/img-thumbs/280h/people-man_KA4U9AQ17G.jpg" },



        };
        public IActionResult Index()
        {
            ViewData["Lecturers"] = lecturer;
            
            return View();
        }
        public IActionResult Details(int id )
        {
            LecturerModel DLecturer = lecturer.Find(p => p.LecturerId == id);
            if (DLecturer == null)
            {
                return Content("There is no Lecturer with this ID ");
            }
            else
            {
                ViewData["DLecturer"] = DLecturer;
                return View();
            }
           
        }
    }
}
