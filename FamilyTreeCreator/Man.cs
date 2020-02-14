using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    public class Man : Person
    {
        public Man(string name, DateTime birthdate) : base(name, birthdate) { }

        public Man(string name, DateTime birthdate, DateTime dateOfDeath) : base(name, birthdate, dateOfDeath) { }

        public void GetWork()
        {
            Console.WriteLine("Doctor");
        }
    }
}
