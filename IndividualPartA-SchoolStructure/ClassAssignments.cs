using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA_SchoolStructure
{
    class ClassAssignments
    {
        private string AssignmentTitle { get; set; }

        private string Description { get; set; }

        private DateTime SubDateTime { get; set; }

        private int OralMark { get; set; }

        private int TotalMark { get; set; }


        public ClassAssignments()
        {
            AssignmentTitle = Get.GetAssignmentTitle();
            Description = Get.GetDescription();
            SubDateTime = Get.GetSubDateTime();
            OralMark = Get.GetOralMark();
            TotalMark = Get.GetTotalMark();
        }

        public virtual void ShowDataAssignments()
        {
            Console.WriteLine($"The assignment title is: {AssignmentTitle}");
            Console.WriteLine($"The assignment description is: {Description}");
            Console.WriteLine($"The assignment submit date time is: {SubDateTime}");
            Console.WriteLine($"The assignament oral mark are: {OralMark}");
            Console.WriteLine($"The assignment total mark are: {TotalMark}");
        }
    }
}
