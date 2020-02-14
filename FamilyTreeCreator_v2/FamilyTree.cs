using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    public class FamilyTree
    {
        Person root;
        Person tail;

        public Person AddManChild(string name, int age)
        {
            Person manChild = new Man(name, age);

            if (root == null)
            {
                root = manChild;
            }
            else
            {
                tail.Child = manChild;
            }

            tail = manChild;

            return tail;
        }

        public Person AddWomanChild(string name, int age)
        {
            Person womanChild = new Woman(name, age);

            if (root == null)
            {
                root = womanChild;
            }
            else
            {
                tail.Child = womanChild;
            }

            tail = womanChild;

            return tail;
        }

        public void PrintFamilyTree(List<Person> familyTree)
        {
            foreach (var person in familyTree)
            {
                Console.WriteLine($"{person.id}. {person}");
            }

            Console.WriteLine();
        }
    }
}
