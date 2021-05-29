using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthChoice.Models;
namespace HealthChoice.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<CustomerModel> siteCustomer = new List<CustomerModel>() {
            new CustomerModel{CustomerName= "Samirah",CustomerAge= 24, CustomerWeight=53, CustomerHeight= 160, CustomerMail= "sara@gmail.com"},
            new CustomerModel{CustomerName= "Sarah",CustomerAge= 18, CustomerWeight=47, CustomerHeight= 158, CustomerMail= "saraha@gmail.com"},
            new CustomerModel{CustomerName= "Ali",CustomerAge= 30, CustomerWeight=70, CustomerHeight= 160, CustomerMail= "Ali@gmail.com"},
            new CustomerModel{CustomerName= "Saif",CustomerAge= 23, CustomerWeight=55, CustomerHeight= 170, CustomerMail= "Saif@gmail.com"},

            };
            return View(siteCustomer);
        }
    }
}
