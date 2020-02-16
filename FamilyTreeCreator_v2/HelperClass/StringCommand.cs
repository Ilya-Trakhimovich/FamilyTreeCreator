using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    public static class StringCommand
    {
        private static string name;
        private static int age;
        private static int id;
        public static string SetPersonName()
        {
            bool flag = true;

            while (flag)
            {
                Console.Write("Enter name: ");

                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    PrintColorMessage("Error! Name is uncorrect.\n");
                }
                else
                {
                    flag = false;
                }
            }

            return name;
        }

        public static int SetPersonAge()
        {
            bool flag = true;

            while (flag)
            {
                Console.Write("Enter age: ");

                bool isNumber = int.TryParse(Console.ReadLine(), out age);

                if (!isNumber || age < 0)
                {
                    PrintColorMessage("Error! Uncorrect age.\n");
                }
                else
                {
                    flag = false;
                }
            }

            return age;
        }

        public static Person GetPersonById(List<Person> personList)
        {
            Person person = null;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Enter person ID: ");

                bool isNumber = int.TryParse(Console.ReadLine(), out id);

                if (isNumber && (id > 0 && id < personList.Count+1))
                {
                    foreach (var per in personList)
                    {
                        if (per.id == id)
                        {
                            person = per;
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    PrintColorMessage("Uncorrect ID.\n");                
                }
            }

            return person; 
        }

        public static void PrintColorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    
    }
}

