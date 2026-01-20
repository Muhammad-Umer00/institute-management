using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Semester
    {
        public string SemesterName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> Courses = new List<Course>();

        public void AddCourse(Course course) {
           Courses.Add(course);
        }

        public void RemoveCourse(Course course) {
            Console.Write("Enter Course Code: ");
            string code = Console.ReadLine();
            Courses.RemoveAll(c => c.courseCode == code);
            Console.WriteLine("removed");
        }
    }
}
