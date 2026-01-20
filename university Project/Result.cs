using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Result
    {
        public string StudentId { get; set; }
        public string CourseCode { get; set; }
        public string Grade { get; set; }
        public Semester Semester { get; set; }

        public void AddResult()
        {
            Console.Write("Enter Student ID: ");
            StudentId = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            CourseCode = Console.ReadLine();

            Console.Write("Enter Grade (A,B,C,D,F): ");
            Grade = Console.ReadLine().ToUpper();

            Console.WriteLine("Select Semester:");
            for (int i = 0; i < Database.Semesters.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Database.Semesters[i].SemesterName}");
            }
            int s = Convert.ToInt32(Console.ReadLine()) - 1;
            Semester = Database.Semesters[s];

            Database.Results.Add(this);

            Console.WriteLine("Result Added Successfully");
        }

        public double CalculateGPA()
        {
            if (Grade == "A")
            {
                return 4.0;
            }
            return 0.0;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"{StudentId} | {CourseCode} | {Grade} | GPA: {CalculateGPA()} | {Semester.SemesterName}");
        }
    }
}