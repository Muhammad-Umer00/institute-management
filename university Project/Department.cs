using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Department
    {
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

        public List<Course> courses = new List<Course>();
        public List<Facultymember> facultymembers = new List<Facultymember>();

        public void display()
        {
            Console.WriteLine($"Department Name : {DepartmentName}");
            Console.WriteLine($"Department Code : {DepartmentName}");
            Console.WriteLine("Faculty Members:");
            foreach (var f in facultymembers)
            {
                Console.WriteLine(f.name);
            }
            foreach (var f in courses)
            {
                Console.WriteLine(f.courseName);
            }
        }
        public void addCourse(Course course)
        {
            courses.Add(course);
        }
        public void removeCourse(Course course)
        {
            courses.Remove(course);
        }
        public void addFaculty(Facultymember fc)
        {
            facultymembers.Add(fc);
        }
        public void removeFaculty(Facultymember fc)
        {
            facultymembers.Remove(fc);
        }
    }
}