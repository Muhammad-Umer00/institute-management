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

        List<Course> courses = new List<Course>;
        List<Facultymember> facultymembers = new List<Facultymember>();

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