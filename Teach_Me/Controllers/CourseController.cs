using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teach_Me.Models;



namespace Teach_Me.Controllers
{
    public class CourseController : Controller
    {
        private List<CourseCategoryModel> _coursecategory = new List<CourseCategoryModel>()
        {


         new CourseCategoryModel { Category_ID = 1, Category_Name ="AI", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU" ,Courses=""},
         new CourseCategoryModel { Category_ID = 2, Category_Name ="Cyber Security", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU" },
         new CourseCategoryModel { Category_ID = 3, Category_Name ="Programming", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU" },
         new CourseCategoryModel { Category_ID = 4, Category_Name ="Data Sience", Category_Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZwLjehVb-iRM_D95NHkAgBFuTLRDrEl5EYw&usqp=CAU" },


        };
       /* private List<CourseModel> _course = new List<CourseModel>()
        {


         new CourseModel { Course_ID = 1, Course_name = "Into CyberSecurity", Course_Description ="",Course_Image="",Date=,Content=""},
         new CourseModel { Course_ID = 2, Course_name = "Into Ethical Haking", Course_Description ="",Course_Image="",Date=,Content=""},
         new CourseModel { Course_ID = 3, Course_name = "What is Social Engeener?", Course_Description ="",Course_Image="",Date=,Content=""},



        };*/
        public IActionResult Index()
        {

            ViewData["CourseCategoryModel"] = _coursecategory; // List NAME
            return View();
        }

    /*
        public IActionResult Details(int ID , string CourseName )
        {

            var course = _coursecategory.Find(model => model.Category_ID == ID || model.Category_Name== CourseName);
            if (course != null)
            {
                ViewData["CourseCategoryModel"] = _coursecategory; 
                return View("Details");
            }
            else
            {
                return Content(" Sorry,This Course NOT found");
            }
        }*/
    }
}
