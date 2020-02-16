using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    class Woman : Person
    {
        public bool isMarried = false;

        public Man Husband { get; set; }

        public Woman(string name, int age) : base(name, age) { }

        public void GetWork()
        {
            Console.WriteLine("Work: Doctor");
        }
    }
}
