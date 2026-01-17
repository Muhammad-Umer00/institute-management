using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal interface ICrud
    {
        void Create(int id, string name, int age, string department, double gpa);
        void Update(int id, string name, int age, string department, double gpa);
        void Delete(int id);
        void Read();

    }
}
