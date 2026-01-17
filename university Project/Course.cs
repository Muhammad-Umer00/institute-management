using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Course
    {
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public string semester { get; set; }
        public string credits { get; set; }
        public void displayCourseInfo()
        {
            Console.WriteLine(courseName + " " + courseCode);
            Console.WriteLine(semester);
            Console.WriteLine(credits);
            
        }
    }
}
