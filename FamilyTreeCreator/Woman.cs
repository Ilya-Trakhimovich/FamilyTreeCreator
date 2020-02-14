using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    public class Woman : Person
    {
        public Woman(string name, DateTime birthdate) : base(name, birthdate) { }
        public Woman(string name, DateTime birthdate, DateTime dateOfDeath) : base(name, birthdate, dateOfDeath) { }

        public void GetHusband()
        {
            Name = Console.ReadLine();
            bool isBirthdate = DateTime.TryParse(Console.ReadLine(), out DateTime birthdate);
            bool isDateOdDeath = DateTime.TryParse(Console.ReadLine(), out DateTime dateOfDeath);
            Person husband = new Man(Name, birthdate, dateOfDeath);
            Married = true;
        }

        public void GerWork()
        {
            Console.WriteLine("Teacher");
        }
    }
}
