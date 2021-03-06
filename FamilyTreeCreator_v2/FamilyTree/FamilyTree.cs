﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    public class FamilyTree
    {
        Person root; // head
        Person lastPerson; // tail

        public Person AddManChild()
        {
            string name = StringCommand.SetPersonName();
            int age = StringCommand.SetPersonAge();

            Person manChild = new Man(name, age);

            if (root == null)
            {
                root = manChild;
            }
            else
            {
                lastPerson.Child = manChild;
            }

            lastPerson = manChild;

            return lastPerson;
        }

        public Person AddWomanChild()
        {
            string name = StringCommand.SetPersonName();
            int age = StringCommand.SetPersonAge();

            Person womanChild = new Woman(name, age);

            if (root == null)
            {
                root = womanChild;
            }
            else
            {
                lastPerson.Child = womanChild;
            }

            lastPerson = womanChild;

            return lastPerson;
        }

        public Person AddWife(List<Person> personList)
        {
            if (personList.Count > 0)
            {
                var person = StringCommand.GetPersonById(personList);
                var man = person as Man;
                bool flag = true;

                while (flag)
                {
                    if (!(man == null) && !StringCommand.ChecSpouse(personList, man))
                    {
                        string name = StringCommand.SetPersonName();
                        int age = StringCommand.SetPersonAge();
                        man.Wife = new Woman(name, age)
                        {
                            Child = man.Child
                        };
                        flag = false;
                    }
                    else
                    {
                        StringCommand.PrintColorMessage("Error!\n");
                        Console.ReadKey();

                        return null;
                    }
                }

                return man.Wife;
            }
            else
            {
                Console.WriteLine("Error");

                return null;
            }
        }

        public Person AddHusband(List<Person> personList)
        {
            if (personList.Count > 0)
            {
                var person = StringCommand.GetPersonById(personList);
                var woman = person as Woman;
                bool flag = true;

                while (flag)
                {
                    if (!(woman == null) && !StringCommand.ChecSpouse(personList, woman))
                    {
                        string name = StringCommand.SetPersonName();
                        int age = StringCommand.SetPersonAge();
                        woman.Husband = new Man(name, age)
                        {
                            Child = woman.Child
                        };
                        flag = false;
                    }
                    else
                    {
                        StringCommand.PrintColorMessage("Error!\n");
                        Console.ReadKey();

                        return null;
                    }
                }

                return woman.Husband;
            }
            else
            {
                Console.WriteLine("Error.");

                return null;
            }
        }

        public void GetBigraphy(List<Person> personList)
        {
            if (personList.Count > 0)
            {
                Person person = StringCommand.GetPersonById(personList);

                if (person is Man man)
                {
                    Console.WriteLine(
                        $"Name: {man.Name}\n" +
                        $"Age: {man.Age}\n" +
                        $"Wife: {man.Wife?.Name}\n" +
                        $"Child: {man.Child?.Name}\n" +
                        $"Work: {man.job}");

                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (person is Woman woman)
                {
                    Console.WriteLine(
                            $"Name: {woman.Name}\n" +
                            $"Age: {woman.Age}\n" +
                            $"Wife: {woman.Husband?.Name}\n" +
                            $"Child: {woman.Child?.Name}\n" +
                            $"Work: {woman.job}");

                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
        }

        public void PrintFamilyTree(List<Person> familyTree) // shows family relativeship in color 
        {
            if (familyTree.Count == 0)
            {
                StringCommand.PrintColorMessage("EMPTY TREE");
            }
            else
            {
                Person per = familyTree[0];

                bool flag = true;

                while (flag)
                {
                    if (!(per.Child == null))
                    {
                        if (per is Man man)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"{man.id}. {man} ");
                            Console.ResetColor();
                            Console.WriteLine($"  {man.Wife?.id} {man.Wife?.Name}");
                        }
                        if (per is Woman woman)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"{woman.id}. {woman} ");
                            Console.ResetColor();
                            Console.WriteLine($"  {woman.Husband?.id} {woman.Husband?.Name}");
                        }
                    }
                    else // for first element
                    {
                        if (per is Man man)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"{man.id}. {man} ");
                            Console.ResetColor();
                            Console.WriteLine($"  {man.Wife?.id} {man.Wife?.Name}");
                        }
                        if (per is Woman woman)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"{woman.id}. {woman} ");
                            Console.ResetColor();
                            Console.WriteLine($"  {woman.Husband?.id} {woman.Husband?.Name}");
                        }

                        return;
                    }

                    per = per.Child;
                }
            }

            Console.WriteLine();
        }
    }
}
