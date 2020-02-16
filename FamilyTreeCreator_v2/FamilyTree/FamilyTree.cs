using System;
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

        public Person AddWife(List<Person> personList) // TODO: bug: method allows add new wife to new husband
        {
            if (personList.Count > 0)
            {
                var person = StringCommand.GetPersonById(personList);
                var man = person as Man;
                bool flag = true;

                while (flag)
                {
                    if (!(man == null))
                    {
                        string name = StringCommand.SetPersonName();
                        int age = StringCommand.SetPersonAge();
                        man.Wife = new Woman(name, age)
                        {
                            isMarried = true
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

        public Person AddHusband(List<Person> personList) // TODO: bug: method allows add new husband to new wife
        {
            if (personList.Count > 0)
            {
                var person = StringCommand.GetPersonById(personList);
                var woman = person as Woman;
                bool flag = true;

                while (flag)
                {
                    if (!(woman == null))
                    {
                        string name = StringCommand.SetPersonName();
                        int age = StringCommand.SetPersonAge();
                        woman.Husband = new Man(name, age)
                        {
                            isMarried = true
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
                        $"Child: {man.Child?.Name}");
                    man.GetWork();
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else if (person is Woman woman)
                {
                    Console.WriteLine(
                            $"Name: {woman.Name}\n" +
                            $"Age: {woman.Age}\n" +
                            $"Wife: {woman.Husband?.Name}\n" +
                            $"Child: {woman.Child?.Name}");
                    woman.GetWork();
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
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"{per.id}. {per}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"{per.id}. {per}");
                        Console.ResetColor();

                        return;
                    }

                    per = per.Child;
                }
            }

            Console.WriteLine();
        }
    }
}
