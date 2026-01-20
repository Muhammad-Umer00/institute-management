using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace university_Project
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Program2 Program { get; set; }
        public Semester Semester { get; set; } 
        public List<Course> Courses = new List<Course>();

        public void RegisterCourse(Course course)
        {
            Courses.Add(course);
        }


        public void DropCourse(Course course) {
            Courses.Remove(course);
        }


        public void DisplayStudentInfo()
        {
            Console.WriteLine($"ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");

            Console.WriteLine("Registered Courses:");

            foreach (var course in Courses)
            {
                Console.WriteLine($"{course.courseName} {course.courseCode}");
            }
            
        }
    }
}