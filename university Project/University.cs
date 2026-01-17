using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class University
    {
        public string universityName = "Hamdard university";
        public string location = "Norht nazimabad";

        public List<Department> Departments = new List<Department>();

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        public void removeDepartment(Department department)
        {
            Departments.Remove(department);
        }
        public void ListDepartments()
        {
            foreach (var dept in Departments)
            {
                Console.WriteLine($"Department Name: {dept.DepartmentName}, Department Code: {dept.DepartmentCode}");
            }
        }
        
    }
}
