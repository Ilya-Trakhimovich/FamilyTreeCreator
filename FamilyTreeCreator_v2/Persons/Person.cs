using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    public class Person
    {
        public static int sId = 1;
        public int id;
        public int generation = 0;
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person() : this ("", default) { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            id = sId;
            sId++;
        }

        public Person Child { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
