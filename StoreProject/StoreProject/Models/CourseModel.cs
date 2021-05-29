using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseRating { get; set; }
        public string CourseLecturer { get; set; }
        public string CourseSummary { get; set; }
        public float CoursePrice { get; set; }
        public string CourseImg { get; set; }

    }
}
