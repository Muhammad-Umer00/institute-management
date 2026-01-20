using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Attendance
    {
        public string StudentId { get; set; }
        public string CourseCode { get; set; }
        public float AttendancePercentage { get; set; }

        public void MarkAttendance()
        {
            Console.Write("Enter Student ID: ");
            StudentId = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            CourseCode = Console.ReadLine();

            Console.Write("Enter Attendance Percentage: ");
            AttendancePercentage = float.Parse(Console.ReadLine());

            Database.Attendances.Add(this);

            Console.WriteLine("Attendance Marked Successfully");
        }

        public void UpdateAttendance()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            string code = Console.ReadLine();

            var a = Database.Attendances.FirstOrDefault(x => x.StudentId == id && x.CourseCode == code);

            if (a != null)
            {
                Console.Write("Enter New Attendance %: ");
                a.AttendancePercentage = float.Parse(Console.ReadLine());
                Console.WriteLine("Attendance Updated");
            }
            else
                Console.WriteLine("Record Not Found");
        }

        public void DisplayAttendance()
        {
            Console.WriteLine($"{StudentId} | {CourseCode} | {AttendancePercentage}%");
        }
    }
}

