using System;
using System.Collections.Generic;

namespace FamilyTreeCreator_v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            bool flag = true;
            FamilyTree family = new FamilyTree();
            List<Person> familyList = new List<Person>();

            while (flag)
            {                
                int choice = menu.ShowMenu(family, familyList);

                var tempChoice = (ActionMenu)choice;

                switch (tempChoice)
                {
                    case ActionMenu.AddMan:
                        {
                            Person per = family.AddManChild("Igor", 123);
                            familyList.Add(per);

                            break;
                        }
                    case ActionMenu.AddWoman:
                        {
                            Person per = family.AddWomanChild("Olga", 1234);
                            familyList.Add(per);

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
    }
}
