using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    
        internal class Examination
        {
            public string ExamName { get; set; }
            public DateTime ExamDate { get; set; }
            public List<Course> Courses = new List<Course>();

            public void ScheduleExam()
            {
                Console.Write("Enter Exam Name: ");
                ExamName = Console.ReadLine();

                Console.Write("Enter Exam Date (yyyy-mm-dd): ");
                ExamDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Select Courses for Exam:");

                for (int i = 0; i < Database.courses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Database.courses[i].courseName}");
                }

                Console.Write("How many courses to add: ");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    Console.Write("Select course number: ");
                    int index = Convert.ToInt32(Console.ReadLine()) - 1;
                    Courses.Add(Database.courses[index]);
                }

                Database.exams.Add(this);

                Console.WriteLine("Exam Scheduled Successfully!");
            }

            public void DisplayExamSchedule()
            {
                Console.WriteLine($"Exam: {ExamName} | Date: {ExamDate.ToShortDateString()}");
                Console.WriteLine("Courses:");
                foreach (var c in Courses)
                {
                    Console.WriteLine($"- {c.courseName}");
                }
            }
        }
    }


