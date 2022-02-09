using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA_SchoolStructure
{
    class ClassTrainers
    {
        private string FirstName { get; set; }

        private string LastName { get; set; }

        private string Subject { get; set; }


        public ClassTrainers()
        {
            FirstName = Get.GetTrainerFirstName();
            LastName = Get.GetTrainerLastName();
            Subject = Get.GetTrainerSubject();

        }

        public virtual void ShowDataTrainers()
        {
            Console.WriteLine($"Trainer first name is: {FirstName}");
            Console.WriteLine($"Trainer last name is: {LastName}");
            Console.WriteLine($"Trainer subject is: {Subject}");

        }


    }
}
