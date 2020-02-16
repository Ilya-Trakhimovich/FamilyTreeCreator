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
                "  Add a man (new generation)",
                "  Add a woman (new generation)",
                "  Add a wife",
                "  Add a husband",
                "  Biography",
                "  Exit."
            };

        private void MoveArrow(int moveChoice, List<Person> famList)
        {
            Console.Clear();

            FamilyTree fam = new FamilyTree();

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

        public int ShowMenu(List<Person> famlist)
        {
            int choice = 0;
            Console.CursorVisible = false;

            while (true)
            {
                MoveArrow(choice, famlist);

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
