using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartA_SchoolStructure
{
    class Get
    {
        public static List<ClassCourses> Courses { get; set; } = new List<ClassCourses>();
        public static List<ClassTrainers> Trainers { get; set; } = new List<ClassTrainers>();
        public static List<ClassStudents> Students { get; set; } = new List<ClassStudents>();
        public static List<ClassAssignments> Assignments { get; set; } = new List<ClassAssignments>();
        public static List<int> CoursesId { get; set; } = new List<int>();
        public static List<int> TrainersId { get; set; } = new List<int>();
        public static List<int> StudentsId { get; set; } = new List<int>();
        public static List<int> AssignmentsId { get; set; } = new List<int>();


        // 
        // Dinw times gia thn klash Courses
        //

        public static string GetCourseTitle()
        {
            Console.WriteLine("Enter the title of the course");
            string courseTitle = Console.ReadLine();
            return courseTitle;
        }

        public static string GetCourseStream()
        {
            Console.WriteLine("Enter the stream of the course");
            string courseStream = Console.ReadLine();
            return courseStream;
        }

        public static string GetCourseType()
        {
            Console.WriteLine("Enter the type of the course");
            string courseType = Console.ReadLine();
            return courseType;
        }

        public static DateTime GetStartDate()
        {
            Console.WriteLine("Enter the starting date of the course (dd/mm/yyyy)");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            return startDate;
        }

        public static DateTime GetEndDate()
        {
            Console.WriteLine("Enter the ending date of the course (dd/mm/yyyy)");
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            return endDate;
        }
        
        public static int GetCourseId()
        {
            Console.WriteLine("Enter an ID for the course");
            int courseId = int.Parse(Console.ReadLine());
            return courseId;
        }

        //
        // Dinw times gia thn klash trainers
        //

        public static string GetTrainerFirstName()
        {
            Console.WriteLine("Enter the first name of the trainer");
            string trainerFirstName = Console.ReadLine();
            return trainerFirstName;
        }

        public static string GetTrainerLastName()
        {
            Console.WriteLine("Enter the last name of the trainer");
            string trainerLastName = Console.ReadLine();
            return trainerLastName;
        }

        public static string GetTrainerSubject()
        {
            Console.WriteLine("Enter the subject of the trainer");
            string subject = Console.ReadLine();
            return subject;
        }

        public static int GetTrainerId()
        {
            Console.WriteLine("Enter an ID for the trainer");
            int trainerId = int.Parse(Console.ReadLine());
            return trainerId;
        }

        //
        // Dinw times gia thn klash Students
        //

        public static string GetStudentFirstName()
        {
            Console.WriteLine("Enter the first name of the student");
            string studentFirstName = Console.ReadLine();
            return studentFirstName;
        }

        public static string GetStudentLastName()
        {
            Console.WriteLine("Enter the last name of the student");
            string studentLastName = Console.ReadLine();
            return studentLastName;
        }

        public static DateTime GetStudentDateOfBirth()
        {
            Console.WriteLine("Enter the date of birth of the student (dd/mm/yyyy)");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            return dateOfBirth;
        }

        public static double GetTuitionFees()
        {
            Console.WriteLine("Enter the tuition fees of the student");
            double tuitionFees = double.Parse(Console.ReadLine());
            return tuitionFees;
        }

        public static int GetStudentId()
        {
            Console.WriteLine("Enter the ID of the Student");
            int studentId = int.Parse(Console.ReadLine());
            return studentId;
        }

        //
        // Dinw times gia thn klash Assignments
        //

        public static string GetAssignmentTitle()
        {
            Console.WriteLine("Enter the title of the assignment");
            string assignmentTitle = Console.ReadLine();
            return assignmentTitle;
        }

        public static string GetDescription()
        {
            Console.WriteLine("Enter the description of the assignment");
            string assignmentDescription = Console.ReadLine();
            return assignmentDescription;
        }

        public static DateTime GetSubDateTime()
        {
            Console.WriteLine("Enter the deadline of the assignment");
            DateTime subDateTime = DateTime.Parse(Console.ReadLine());
            return subDateTime;
        }

        public static int GetOralMark()
        {
            Console.WriteLine("Enter the oral mark of the assignment");
            int oralMark = int.Parse(Console.ReadLine());
            return oralMark;
        }

        public static int GetTotalMark()
        {
            Console.WriteLine("Enter the total mark of the assignment");
            int totalMark = int.Parse(Console.ReadLine());
            return totalMark;
        }

        public static int GetAssignmentId()
        {
            Console.WriteLine("Enter the ID of the Assignment");
            int assignmentId = int.Parse(Console.ReadLine());
            return assignmentId;
        }






        public static void Create()
        {
            while (true)
            {
                Console.WriteLine("Would you like to create a Course(C), a Trainer(T), a Student(S) or an Assignment(A)? If you want to stop type (stop)");
                string answer1 = Console.ReadLine();
                if (answer1 == "C")
                {                                      
                    ClassCourses course = new ClassCourses();
                    Courses.Add(course);

                    Console.WriteLine("Type the ID of the course...");
                    int courseId = int.Parse(Console.ReadLine());
                    CoursesId.Add(courseId);
                }
                else if(answer1 == "T")
                {
                    ClassTrainers trainer = new ClassTrainers();
                    Trainers.Add(trainer);

                    Console.WriteLine("Type the ID of the trainer...");
                    int trainerId = int.Parse(Console.ReadLine());
                    TrainersId.Add(trainerId);
                }
                else if(answer1 == "S")
                {
                    ClassStudents student = new ClassStudents();
                    Students.Add(student);

                    Console.WriteLine("Type the ID of the sudent...");
                    int studentId = int.Parse(Console.ReadLine());
                    StudentsId.Add(studentId);
                }
                else if(answer1 == "A")
                {
                    ClassAssignments assignment = new ClassAssignments();
                    Assignments.Add(assignment);

                    Console.WriteLine("Type the ID of the assignment...");
                    int assgnmentId = int.Parse(Console.ReadLine());
                    AssignmentsId.Add(assgnmentId);
                }
                else if(answer1 == "stop")
                {
                    break;
                }
            }
            for (int i = 0; i < Courses.Count; i++)
            {
                Courses[i].ShowDataCourses();
                Console.WriteLine($"Course ID: {CoursesId[i]}");
            }
            for (int i = 0; i < Trainers.Count; i++)
            {
                Trainers[i].ShowDataTrainers();
                Console.WriteLine($"Trainer ID: {TrainersId[i]}");
            }
            for (int i = 0; i < Students.Count; i++)
            {
                Students[i].ShowDataStudents();
                Console.WriteLine($"Student ID: {StudentsId[i]}");
            }
            for (int i = 0; i < Assignments.Count; i++)
            {
                Assignments[i].ShowDataAssignments();
                Console.WriteLine($"Assignment ID: {AssignmentsId[i]}");
            }

            Console.WriteLine("Do you want to add a student to a course? (Y/N)");
            string answer2 = Console.ReadLine();
            if (answer2 == "Y")
            {

                Console.WriteLine("Type the ID of the student..");
                int studentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the ID of the course..");
                int courseId = int.Parse(Console.ReadLine());


                for (int i = 0; i <= StudentsId.Count; i++)
                {
                    if(studentId == StudentsId[i])
                    {
                        Console.WriteLine("You add the student: ");
                        Students[i].ShowDataStudents();
                        break;
                    }
                }
                for(int j = 0; j <= CoursesId[j]; j++)
                {
                    if (courseId == CoursesId[j])
                    {
                        Console.WriteLine("To the course: ");
                        Courses[j].ShowDataCourses();
                        break;
                    }
                }
            }

            Console.WriteLine("Do you want to add a trainer to a course? (Y/N)");
            string answer3 = Console.ReadLine();
            if (answer3 == "Y")
            {

                Console.WriteLine("Type the ID of the trainer..");
                int trainerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the ID of the course..");
                int courseId = int.Parse(Console.ReadLine());


                for (int i = 0; i <= TrainersId.Count; i++)
                {
                    if (trainerId == TrainersId[i])
                    {
                        Console.WriteLine("You add the trainer: ");
                        Trainers[i].ShowDataTrainers();
                        break;
                    }
                }
                for (int j = 0; j <= CoursesId[j]; j++)
                {
                    if (courseId == CoursesId[j])
                    {
                        Console.WriteLine("To the course: ");
                        Courses[j].ShowDataCourses();
                        break;
                    }
                }
            }

            Console.WriteLine("Do you want to add a assignment to a course? (Y/N)");
            string answer4 = Console.ReadLine();
            if (answer4 == "Y")
            {

                Console.WriteLine("Type the ID of the assignment..");
                int assignmentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the ID of the course..");
                int courseId = int.Parse(Console.ReadLine());


                for (int i = 0; i <= AssignmentsId.Count; i++)
                {
                    if (assignmentId == AssignmentsId[i])
                    {
                        Console.WriteLine("You add the assignment: ");
                        Assignments[i].ShowDataAssignments();
                        break;
                    }
                }
                for (int j = 0; j <= CoursesId[j]; j++)
                {
                    if (courseId == CoursesId[j])
                    {
                        Console.WriteLine("To the course: ");
                        Courses[j].ShowDataCourses();
                        break;
                    }
                }
            }

            Console.WriteLine("Do you want to add a student per course and per assignment? (Y/N)");
            string answer5 = Console.ReadLine();
            if (answer5 == "Y")
            {

                Console.WriteLine("Type the ID of the student..");
                int studentId = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the ID of the course..");
                int courseId = int.Parse(Console.ReadLine());
                Console.WriteLine("Type the ID of the assignment..");
                int assignmentId = int.Parse(Console.ReadLine());


                for (int i = 0; i <= StudentsId.Count; i++)
                {
                    if (studentId == StudentsId[i])
                    {
                        Console.WriteLine("You add the student: ");
                        Students[i].ShowDataStudents();
                        break;
                    }
                }
                for (int j = 0; j <= CoursesId[j]; j++)
                {
                    if (courseId == CoursesId[j])
                    {
                        Console.WriteLine("To the course: ");
                        Courses[j].ShowDataCourses();
                        break;
                    }
                }
                for (int k = 0; k <= AssignmentsId.Count; k++)
                {
                    if (assignmentId == AssignmentsId[k])
                    {
                        Console.WriteLine("And to the assignment: ");
                        Assignments[k].ShowDataAssignments();
                        break;
                    }
                }
            }
        }
    }
}
