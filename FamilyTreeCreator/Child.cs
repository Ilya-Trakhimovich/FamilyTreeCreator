using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    public class Child : Person
    {
        public Child(string name, DateTime birthdate) : base(name, birthdate)
        {
        }

        public Child(string name, DateTime birthdate, DateTime dateOfDeath) : base(name, birthdate, dateOfDeath)
        {
        }

        public void FetEducation()
        {
            Console.WriteLine("School");
        }
    }
}
