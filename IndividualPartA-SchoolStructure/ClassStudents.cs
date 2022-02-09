using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA_SchoolStructure
{
    class ClassStudents
    {
        private string FirstName { get; set; }

        private string LastName { get; set; }

        private DateTime DateOfBirth { get; set; }

        private double TuitionFees { get; set; }


        public ClassStudents()
        {
            FirstName = Get.GetStudentFirstName();
            LastName = Get.GetStudentLastName();
            DateOfBirth = Get.GetStudentDateOfBirth();
            TuitionFees = Get.GetTuitionFees();
        }

        public virtual void ShowDataStudents()
        {
            Console.WriteLine($"Student first name is: {FirstName}");
            Console.WriteLine($"Student last name is: {LastName}");
            Console.WriteLine($"Student date of birth is: {DateOfBirth}");
            Console.WriteLine($"Student tuition fees are: {TuitionFees}");
        }

    }
}
