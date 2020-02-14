using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    class Man : Person
    {
        public Man(string name, int age) : base(name, age) { }

        public Woman Wife { get; set; }

        public void GetWork()
        {
            Console.WriteLine("Engineer");
        }
    }
}
