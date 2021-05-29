using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nike_Store.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nike_Store.Controllers
{
    public class CategoriesController : Controller
    {
        public List<CategorieModel> CategorieList = new List<CategorieModel>()
        {
        new CategorieModel() {Id = 1, Categorie = "Mens" , Img = "https://images.unsplash.com/photo-1601790583791-6f718449bfb3?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80"},
        new CategorieModel() {Id = 2, Categorie = "Women" , Img = "https://images.unsplash.com/photo-1613338442882-b4d4643877c3?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1526&q=80" },
        new CategorieModel() {Id = 3, Categorie = "Kids" , Img = "https://images.unsplash.com/photo-1528799547354-c537ef886c35?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1650&q=80" }
        };
        // GET: Categories/
        public IActionResult Index()
        {
            ViewData["Categories"] = CategorieList;
            return View();
        }

        public List<MenProudctsModel> Proudctlist = new List<MenProudctsModel>()
        {
            new MenProudctsModel() {Id=1 , Type="Football", Size=44, Price=1400, Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/8418344d-7406-4fb2-a9f2-6e2b2742a878/tiempo-legend-8-academy-tf-artificial-football-shoe-8wt4CZ.png"},
            new MenProudctsModel() {Id=2 , Type="Running",  Size=45, Price=456 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/788711e8-19e1-40e3-b678-c90d99c35284/juniper-trail-trail-running-shoe-36hHZ7.png"},
            new MenProudctsModel() {Id=3 , Type="Training & Gym", Size=46, Price=398 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/06b07bef-69b5-4872-af79-f0c685d07784/superrep-go-2-training-shoe-bQbD5z.png"},
            new MenProudctsModel() {Id=4 , Type="Football", Size=46, Price=560 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/bd6621a9-bd43-470f-9f49-81d6ebe16d2d/mercurial-superfly-8-academy-tf-football-shoe-28FgCt.png"},
            new MenProudctsModel() {Id=5 , Type="Training & Gym", Size=44, Price=1680 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/656378dd-c83a-4234-a446-30474da3b9ac/savaleos-weightlifting-shoe-vmDWXb.png"},
            new MenProudctsModel() {Id=6 , Type="Lifestyle",  Size=44, Price=667 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/65d1ceac-fafb-4f17-87a7-f560b804a5fc/air-max-2090-eoi-shoe-1M4pG7.png"},
            new MenProudctsModel() {Id=6 , Type="Football",  Size=45, Price=489 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/855d7d13-7604-47e1-83f8-3f641aee8344/tiempo-legend-8-club-mg-multi-ground-football-boot-C9tpTf.png"},
            new MenProudctsModel() {Id=7 , Type="Lifestyle",  Size=45, Price=700 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/3a170971-dd8c-46df-a2fa-59a60076413d/air-max-2090-shoe-NGbdqr.png"},
            new MenProudctsModel() {Id=8 , Type="Lifestyle",  Size=43, Price=890 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/ad197ac2-f018-4e31-b234-120b15216182/crater-impact-shoe-0v24WZ.png"},
            new MenProudctsModel() {Id=9 , Type="Football", Size=47, Price=876 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/6ce08532-00c4-4518-8686-acab59cafdf0/phantom-gt-elite-dynamic-fit-fg-football-boot-LqScf8.png"},
            new MenProudctsModel() {Id=10 , Type="Lifestyle", Size=47, Price=1567 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/3f0a8b6a-945b-49dd-b274-f79f20077244/air-presto-shoe-bQhR6b.png"},
            new MenProudctsModel() {Id=11 , Type="Training & Gym", Size=45, Price=890 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/2029f9ae-4122-4ad1-b12f-bf6574f497d4/free-metcon-4-training-shoe-gJXqKd.png"},
            new MenProudctsModel() {Id=12 , Type="Running",Size=44, Price=480 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/f7b013f8-0e2c-4dce-ad53-4ce4ed10eccb/air-zoom-terra-kiger-7-trail-running-shoe-PFRMNz.png"},
            new MenProudctsModel() {Id=13 , Type="Running", Size=43, Price=670 , Img ="https://static.nike.com/a/images/c_limit,w_592,f_auto/t_product_v1/db189256-58d2-4c7c-99ef-153cc52ce4e1/air-zoom-structure-23-running-shoe-Lh3fPW.png"}
        };
        // GET: Categories/Men
        public IActionResult Men()
        {
                ViewData["MenProducts"] = Proudctlist;
                return View();
        }
       
    }
}
