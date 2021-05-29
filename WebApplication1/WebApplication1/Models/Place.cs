using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Place
    {
        [Key]
        public int placeId { get; set; }

        [Column( TypeName = "nvarchar(200)" )]
        public string placeName { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string description { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string type { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string area { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string photo { get; set; }

    }
}
