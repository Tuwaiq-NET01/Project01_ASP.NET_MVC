using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City_Guide.Models
{
    public class RestaurantModel
    {
            public int Id { get; set; }
            public String name { get; set; }
            public String location { get; set; }
            public String image { get; set; }
            public int phoneNumber { get; set; }
            public String description { get; set; }
            public String reviews { get; set; }
    }
   
}
