using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class LecturerModel
    {
        public int LecturerId { get; set; }
        public string LecturerName { get; set; }
        public float LecturerPrice { get; set; } // FREELANCING PRICE
        public string LecturerImg { get; set; }
        public string LecturerSummary { get; set; }
        public string LecturerRating { get; set; }
       // public CourseModel MyProperty { get; set; }
        public int LecturerCourse { get; set; }

    }
}
