using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;

namespace GameStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {

        private IList<CustomerModel> cus;

        //public CustomersController(CustomerModel Customer)
        public CustomersController()
        {
            this.cus = new List<CustomerModel>
            {
                new CustomerModel
                {
                    Id = 1,
                    Name = "Daniel Lo Nigro",
                    Website = "FAS@gmail.com"
                },
                new CustomerModel
                {
                    Id = 2,
                    Name = "Pete Hunt",
                    Website = "FAS@gmail.com"
                },
                new CustomerModel
                {
                    Id = 3,
                    Name = "Jordan Walke",
                    Website = "FAS@gmail.com"
                },
            };
        }

        [HttpGet]
       // public IEnumerable<WeatherForecast> Get()
        public IList<CustomerModel> Get()
        {
            return cus;
        }
        /*public ActionResult Index()
        {
            return (ActionResult)Json(cus);
        }
        public ActionResult Comments()
        {
            return (ActionResult)Json(cus);
        }

        private IList<CustomerModel> Json(IList<CustomerModel> cus)
        {
            return this.cus;
        }*/
    }
}
