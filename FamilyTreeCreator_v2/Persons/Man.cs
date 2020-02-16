using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    class Man : Person
    {
        public bool isMarried = false;

        public Woman Wife { get; set; }

        public Man(string name, int age) : base(name, age) { }

        public void GetWork()
        {
            Console.WriteLine("Work: Engineer");
        }
    }
}
