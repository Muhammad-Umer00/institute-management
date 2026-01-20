using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace university_Project
{
    internal class Program

    {

        public static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "st.txt");

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, University Project!");
            string roleask = "What is your Role";
            string role1 = "Admin";
            string role2 = "Visitor";
            string exitcmd = "Exit";
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(roleask);
                Console.WriteLine($"1- {role1}");
                Console.WriteLine($"2- {role2}");
                Console.WriteLine($"3- {exitcmd}");
                int role = Convert.ToInt32(Console.ReadLine());

                if (role > 0 && role < 4)
                {

                    switch (role)
                    {
                        case 1:
                            //Admin admin = new Admin();
                            //admin.AdminMenu();
                            Console.WriteLine("Admin-Login functionality is under development.");
                            break;
                        case 2:
                            Visitor visitor = new Visitor();
                            visitor.VisitorMenu();
                            break;
                        case 3:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number corresponding to your role.");
                }

            }
        }
    }
    }



