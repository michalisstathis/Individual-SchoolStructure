using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA_SchoolStructure
{
    class ClassCourses
    {
        private string CourseTitle { get; set; }

        private string CourseStream { get; set; }

        private string CourseType { get; set; }

        private DateTime CourseStartDate { get; set; }

        private DateTime CourseEndDate { get; set; }

        public ClassCourses()
        {
            CourseTitle = Get.GetCourseTitle();
            CourseStream = Get.GetCourseStream();
            CourseType = Get.GetCourseType();
            CourseStartDate = Get.GetStartDate();
            CourseEndDate = Get.GetEndDate();
        }

        public virtual void ShowDataCourses()
        {
            Console.WriteLine($"Course title: {CourseTitle}");
            Console.WriteLine($"Course stream: {CourseStream}");
            Console.WriteLine($"Course type: {CourseType}");
            Console.WriteLine($"Course starting date: {CourseStartDate}");
            Console.WriteLine($"Course ending date: {CourseEndDate}");
        }
    }
}
