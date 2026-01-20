using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Facultymember
    {
        public string facultyId { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public Department department { get; set; }

        public void displayFacultyinfo()
        {
            Console.WriteLine($"ID: {facultyId} NAME: {name} DESIGNATION: {designation}");
        }
        public void assigncourse()
        {

        }
    }
}
