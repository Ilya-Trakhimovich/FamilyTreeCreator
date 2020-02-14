using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    public class Menu
    {
        private const string _arrow = "--> ";
        private readonly string[] _menu =
            {
                "  Add a man",
                "  Add a woman",
                "  Exit."
            };

        private void MoveArrow(int moveChoice, FamilyTree fam, List<Person> famList)
        {
            Console.Clear();

            fam.PrintFamilyTree(famList);

            for (var i = 0; i < _menu.Length; i++)
            {
                if (i == moveChoice)
                {
                    Console.Write(_arrow);
                }                 

                Console.WriteLine(_menu[i]);
            }
        }

        public int ShowMenu(FamilyTree famtree, List<Person> famlist)
        {
            int choice = 0;
            Console.CursorVisible = false;

            while (true)
            {
                MoveArrow(choice, famtree, famlist);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (choice != 0)
                            {
                                --choice;
                            }

                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (choice != _menu.Length - 1)
                            {
                                ++choice;
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            return choice;
                        }
                }
            }
        }
    }
}
