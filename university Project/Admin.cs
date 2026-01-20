using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Admin
    {

      
        void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Student Menu ----");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Back");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) AddStudent();
            else if (ch == 2) ViewStudents();
            else if (ch == 3) RemoveStudent();
        }
        void AddStudent()
        {
            Student s = new Student();
            Course c = new Course();
            Semester s2 = new Semester();
            Program2 p = new Program2();
            Console.Write("Enter ID: ");
            Console.WriteLine(Database.students.Count);
            int id = Convert.ToInt32(Console.ReadLine());
            if (id > 0 && id > Database.students.Count)
            {
                s.StudentId = id;
            }
            else
            {
                Console.Write("Student Id Existing.....");
                return;
            }
            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();
            Console.Write("Program : ");
            p.ProgramName = Console.ReadLine();
            Console.Write("Assign Course ");
            c.courseName = Console.ReadLine();
            Console.Write("Course code ");
            c.courseCode = Console.ReadLine();
            Console.Write("Semester");
            s2.SemesterName = Console.ReadLine();
            s.Semester = s2;
            s.Program = p;
            s.RegisterCourse(c);
            Database.students.Add(s);
            Console.WriteLine("Student Added Successfully");
            Console.ReadKey();
        }

        void ViewStudents()
        {
            foreach (var student in Database.students)
            {
                student.DisplayStudentInfo();
                Console.Write($"Semester {student.Semester.SemesterName}");
                Console.Write($"Program {student.Program.ProgramName}");

            }
            Console.ReadKey();
        }

        void RemoveStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Database.students.RemoveAll(s => s.StudentId == id);
            Console.WriteLine("Removed");
            Console.ReadKey();
        }


        void CourseMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Course Menu ----");
            Console.WriteLine("1. Add Course");
            Console.WriteLine("2. View Courses");
            Console.WriteLine("3. Remove Course");
            Console.WriteLine("4. Back");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) AddCourse();
            else if (ch == 2) ViewCourses();
            else if (ch == 3) RemoveCourse();
        }

        void AddCourse()
        {
            Course c = new Course();
            Console.Write("Enter Code: ");
            c.courseCode = Console.ReadLine();
            Console.Write("Enter Name: ");
            c.courseName = Console.ReadLine();
            Console.Write("Semester: ");
            c.semester = Console.ReadLine();
            Console.Write("Credits:");
            c.credits = Console.ReadLine();


            Database.courses.Add(c);

            Console.WriteLine("Course Added");
            Console.ReadKey();
        }
        void AddCourse(Department dept)
        {
            Course c = new Course();
            Console.Write("Enter Code: ");
            c.courseCode = Console.ReadLine();
            Console.Write("Enter Name: ");
            c.courseName = Console.ReadLine();
            Console.Write("Semester: ");
            c.semester = Console.ReadLine();
            Console.Write("Credits:");
            c.credits = Console.ReadLine();

            dept.addCourse(c);
            Database.courses.Add(c);

            Console.WriteLine("Course Added");
            Console.ReadKey();
        }

        void ViewCourses()
        {
            foreach (var c in Database.courses)
                c.displayCourseInfo();

            Console.ReadKey();
        }

        void RemoveCourse()
        {
            Console.Write("Enter Course Code: ");
            string code = Console.ReadLine();
            Database.courses.RemoveAll(c => c.courseCode == code);
            Console.WriteLine("Removed");
            Console.ReadKey();
        }

        void FacultyMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Faculty Menu ----");
            Console.WriteLine("1. Add Faculty");
            Console.WriteLine("2. View Faculty");
            Console.WriteLine("3. Remove Faculty");
            Console.WriteLine("4. Back");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) AddFaculty();
            else if (ch == 2) ViewFaculty();
            else if (ch == 3) RemoveFaculty();
        }

        void AddFaculty()
        {
            Facultymember f = new Facultymember();
            Department d = new Department();    
            Console.Write("Enter ID: ");
            f.facultyId = Console.ReadLine();
            Console.Write("Enter Name: ");
            f.name = Console.ReadLine();
            Console.Write("Enter designation: ");
            f.designation = Console.ReadLine();
            Console.Write("Enter Department: ");
            d.DepartmentName = Console.ReadLine();
            f.department = d;
            Database.faculty.Add(f);
            Console.WriteLine("Faculty Added");
            Console.ReadKey();
        }
        void AddFaculty(Department dept)
        {
            Facultymember f = new Facultymember();
            
            Console.Write("Enter ID: ");
            f.facultyId = Console.ReadLine();
            Console.Write("Enter Name: ");
            f.name = Console.ReadLine();
            Console.Write("Enter designation: ");
            f.designation = Console.ReadLine();
            dept.addFaculty(f);
            
            Database.faculty.Add(f);
            Console.WriteLine("Faculty Added");
            Console.ReadKey();
        }
        void ViewFaculty()
        {
            foreach (var f in Database.faculty)
            {

                f.displayFacultyinfo();
                Console.WriteLine($"Department {f.department.DepartmentName} ");
            }

            Console.ReadKey();
        }

        void RemoveFaculty()
        {
            Console.Write("Enter Faculty ID: ");
            string id = Console.ReadLine();
            Database.faculty.RemoveAll(f => f.facultyId == id);
            Console.WriteLine("Removed");
            Console.ReadKey();
        }

        void DepartmentMenu()
        {
            Console.Clear();
            Console.WriteLine("---- Faculty Menu ----");
            Console.WriteLine("1. Add Departmeent");
            Console.WriteLine("2. View Department");
            Console.WriteLine("3. Remove Department");
            Console.WriteLine("4. Back");

            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1) AddDepartment();
            else if (ch == 2) viewDepartment();
            else if (ch == 3) removeDepartment();
        }
        void AddDepartment()
        {
            Department d = new Department();
            Facultymember f = new Facultymember();
            Console.Write("Department Name ");
            d.DepartmentName = Console.ReadLine();
            Console.Write("Department Code: ");
            d.DepartmentCode = Console.ReadLine();
            Console.Write("Add Faculty Member");
            Console.Write("how much Faculty Member do u wanna add");
            int opt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < opt; i++)
            {
                AddFaculty(d);
            }
            Console.Write("how much courses do u wanna add");
            int opt2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < opt2; i++)
            {
                AddCourse(d);
            }
            Database.department.Add(d);
            Console.ReadKey();
        }
        void viewDepartment()
        {
            foreach (var d in Database.department)
            {

                d.display();
           
            }

            Console.ReadKey();
        }
        void removeDepartment()
        {

            Console.WriteLine("Enter department code which you wanna remove");
            string code = Console.ReadLine();
            Database.department.RemoveAll(d => d.DepartmentCode == code);
            Console.WriteLine("removed");
            Console.ReadKey();



        }
        void ExamMenu()
        {
            Console.WriteLine("\n--- Examination Management ---");
            Console.WriteLine("1. Schedule Exam");
            Console.WriteLine("2. Update Exam");
            Console.WriteLine("3. Remove Exam");
            Console.WriteLine("4. View Exam Schedule");
            Console.WriteLine("5. Back");

            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Examination ex = new Examination();
                ex.ScheduleExam();
            }
            else if (op == 2)
            {
                Console.Write("Enter exam name to update: ");
                string name = Console.ReadLine();

                var exam = Database.exams.FirstOrDefault(e => e.ExamName == name);
                if (exam != null)
                {
                    Console.Write("Enter new date: ");
                    exam.ExamDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Exam Updated");
                }

            }
            else if (op == 3)
            {
                Console.Write("Enter exam name to delete: ");
                string name = Console.ReadLine();

                var exam = Database.exams.FirstOrDefault(e => e.ExamName == name);
                Database.exams.Remove(exam);
                Console.WriteLine(" Exam Removed");
            }
            else if (op == 4)
            {
                foreach (var e in Database.exams)
                {

                    e.DisplayExamSchedule();
                    Console.ReadKey();
                }
            }



        }
        void ResultMenu()
        {
           
                Console.WriteLine("\n--- Result Management ---");
                Console.WriteLine("1. Add Result");
                Console.WriteLine("2. Calculate GPA");
                Console.WriteLine("3. View Results");
                Console.WriteLine("4. Back");

                int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Result r = new Result();
                r.AddResult();
            }
            else if (op == 2)
            {
                Console.Write("Enter Student ID: ");
                string id = Console.ReadLine();

                var list = Database.Results.Where(x => x.StudentId == id).ToList();

                double total = 0;
                foreach (var r in list)
                    total += r.CalculateGPA();

                Console.WriteLine($"Student GPA = {total / list.Count}");
            }
            else if (op == 3)
            {
                foreach (var r in Database.Results)
                    r.DisplayResult();
            }
            else return;
            
        }
        void AttendanceMenu()
        {
           
                Console.WriteLine("\n--- Attendance Management ---");
                Console.WriteLine("1. Mark Attendance");
                Console.WriteLine("2. Update Attendance");
                Console.WriteLine("3. View Attendance");
                Console.WriteLine("4. Back");

                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Attendance a = new Attendance();
                    a.MarkAttendance();
                }
                else if (op == 2)
                {
                    new Attendance().UpdateAttendance();
                }
                else if (op == 3)
                {
                    foreach (var a in Database.Attendances)
                        a.DisplayAttendance();
                }
                else return;
            
        }

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== ADMIN PANEL =====");
                Console.WriteLine("1. Student Management");
                Console.WriteLine("2. Course Management");
                Console.WriteLine("3. Faculty Management");
                Console.WriteLine("4. Department Management");
                Console.WriteLine("5. Examination Management");
                Console.WriteLine("5. Result Management");
                Console.WriteLine("5. Attendence Management");
                Console.WriteLine("press any key to return");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1: StudentMenu(); break;
                    case 2: CourseMenu(); break;
                    case 3: FacultyMenu(); break;
                    case 4: DepartmentMenu(); break;
                    case 5: ExamMenu(); break;
                    case 6: ResultMenu(); break;
                    case 7: AttendanceMenu(); break;
                    default: return;
                }
            }
        }
    }
}