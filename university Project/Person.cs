using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_Project
{
    internal class Person 
    {
        
        
        private int ID_;
        private string name_;
        private int age_;
        public static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "st.txt");

       
        public int ID
        {
            get
            {
                return ID_;
            }
            set
            { 
                if(value > 0)
                {
                    ID_ = value;
                }
                
            }
        }
        public string Name
        {
            get { return name_; }
            set
            {
                if (value is string)
                {
                    name_ = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age_;
            }
            set
            {
                if (value > 0)
                {
                    age_ = value;
                }

            }
        }

      
    }
}
