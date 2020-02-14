using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    class Woman : Person
    {
        public Woman(string name, int age) : base(name, age) { }

        public Man Husband { get; set; }

        public void GetWork()
        {
            Console.WriteLine("Doctor");
        }
    }
}
