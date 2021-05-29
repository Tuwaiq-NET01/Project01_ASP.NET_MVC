using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Address
    {
        [Key]
        public int addressId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string longitude { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string latitude { get; set; }

        public int placeId { get; set; }
        //  public virtual Place place { get; set; }

        private  Place place;
        
        public virtual Place Place
        {
            get
            {
                return this.place;
            }
            set
            {
                this.place = value;
            }
        }

    }
}
