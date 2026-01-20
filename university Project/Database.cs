using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Database
    {
        public static List<Semester> Semesters = new List<Semester>()
        {
            new Semester
            {
                SemesterName = "Semester 1",
                StartDate = new DateTime(2025, 1, 1),
                EndDate = new DateTime(2025, 6, 30),
                Courses = new List<Course>
                {
                    new Course { courseCode = "CS101", courseName = "Programming Fundamentals", semester = "Semester 1", credits = "3" },
                    new Course { courseCode = "CS102", courseName = "Discrete Math", semester = "Semester 1", credits = "3" }
                }
            },

            new Semester
            {
                SemesterName = "Semester 2",
                StartDate = new DateTime(2025, 7, 1),
                EndDate = new DateTime(2025, 12, 31),
                Courses = new List<Course>
                {
                    new Course { courseCode = "CS201", courseName = "OOP", semester = "Semester 2", credits = "3" },
                    new Course { courseCode = "CS202", courseName = "Data Structures", semester = "Semester 2", credits = "3" }
                }
            }
        };
        public static List<Student> students = new List<Student>()
        {
        new Student() { StudentId=01, Name="Ali", Courses = new List<Course>() {
            new Course() { courseCode="CS101", courseName="Programming", semester="1", credits="3"},
            new Course() { courseCode="CS102", courseName="OOP", semester="2", credits="4"}
        }, Semester = new Semester(){ SemesterName="3"} , Program = new Program2(){ ProgramName="BSCS"} },

        new Student() { StudentId=02, Name="Sara", Courses = new List<Course>() {
            new Course() { courseCode="CS101", courseName="Programming", semester="1", credits="3"},
        }, Semester = new Semester(){ SemesterName="2"} , Program = new Program2(){ ProgramName="BSIT"} }
        };

        public static List<Course> courses = new List<Course>()
        {
        new Course(){ courseCode="CS101", courseName="Programming", semester="1", credits="3"},
        new Course(){ courseCode="CS102", courseName="OOP", semester="2", credits="4"},
        new Course(){ courseCode="CS201", courseName="DBMS", semester="3", credits="3"}
        };

        public static List<Examination> exams = new List<Examination>()
        {
        new Examination(){ ExamName="Mid Term", ExamDate= new DateTime(2026, 3, 15),
            Courses = new List<Course>() { new Course(){ courseCode="CS102", courseName="OOP"} } },

        new Examination(){ ExamName="Final", ExamDate=new DateTime(2026, 5, 16),
            Courses = new List<Course>() { new Course(){ courseCode="CS201", courseName="DBMS"} } }
        };
        public static List<Facultymember> faculty = new List<Facultymember>
        {
            new Facultymember(){ facultyId="F01", designation="Professor", name="Sir Zia" ,
                department = new Department() { DepartmentName = "Technology" }
            },
             new Facultymember(){ facultyId="F02", designation="Head of Department", name="Sir FAsih" ,
                department = new Department() { DepartmentName = "Technology" }
            },
        };
        public static List<Department> department = new List<Department>
        {
           new Department(){ DepartmentCode ="TECH", DepartmentName = "Technology",
               courses = new List<Course>(){
                   new Course() { courseCode="CS101", courseName="Programming", semester="1", credits="3"},
                   new Course() { courseCode="CS102", courseName="OOP", semester="2", credits="4"},
                   new Course() { courseCode="CS201", courseName="DBMS", semester="3", credits="3"}
               },
               facultymembers = new List<Facultymember>(){
                   new Facultymember(){ facultyId="F01", designation="Professor", name="Sir Zia" ,
                department = new Department() { DepartmentName = "Technology" }
              },
             new Facultymember(){ facultyId="F02", designation="Head of Department", name="Sir FAsih" ,
                department = new Department() { DepartmentName = "Technology" }
            },
               }
           }
        };
        public static List<Result> Results = new List<Result>()
        {
            new Result
            {
                StudentId = "S001",
                CourseCode = "CS101",
                Grade = "A",
                Semester = new Semester { SemesterName = "Semester 1" }
            },
            new Result
            {
                StudentId = "S002",
                CourseCode = "CS102",
                Grade = "B",
                Semester = new Semester { SemesterName = "Semester 2" }
            }
        };

        public static List<Attendance> Attendances = new List<Attendance>()
        {
            new Attendance
            {
                StudentId = "S001",
                CourseCode = "CS101",
                AttendancePercentage = 90
            },
            new Attendance
            {
                StudentId = "S002",
                CourseCode = "CS102",
                AttendancePercentage = 82
            }
        };
        //cc
    }
}
