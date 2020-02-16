using System;
using System.Collections.Generic;

namespace FamilyTreeCreator_v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            FamilyTree family = new FamilyTree();
            Person wife = null;
            Person husband = null;
            List<Person> familyList = new List<Person>();
            bool flag = true;

            while (flag)
            {
                int choice = menu.ShowMenu(familyList);

                var tempChoice = (ActionMenu)choice;

                switch (tempChoice)
                {
                    case ActionMenu.AddMan:
                        {
                            Person per = family.AddManChild();
                            familyList.Add(per);

                            GetMessage("The man");

                            break;
                        }
                    case ActionMenu.AddWoman:
                        {
                            Person per = family.AddWomanChild();
                            familyList.Add(per);

                            GetMessage("The woman");

                            break;
                        }
                    case ActionMenu.AddWife:
                        {
                            wife = family.AddWife(familyList);

                            if (!(wife == null))
                            {
                                familyList.Add(wife);

                                GetMessage("The wife");
                            }

                            break;
                        }
                    case ActionMenu.AddHusband:
                        {
                            husband = family.AddHusband(familyList);

                            if (!(husband == null))
                            {
                                familyList.Add(husband);

                                GetMessage("The husband");
                            }

                            break;
                        }
                    case ActionMenu.Biography:
                        {
                            family.GetBigraphy(familyList);

                            break;
                        }
                    case ActionMenu.Exit:
                        {
                            Environment.Exit(0);

                            break;
                        }
                }
            }
        }

        public static void GetMessage(string message)
        {
            Console.WriteLine($"{message} added.");
            Console.ReadKey();
        }
    }
}
