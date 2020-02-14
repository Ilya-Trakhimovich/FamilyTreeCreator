using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    public class Person
    {
        private int _age;
        private DateTime _dateOfDeath;

        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }
        public bool Married { get; set; }
        public DateTime DateOfDeath
        {
            get
            {
                return _dateOfDeath;
            }

            set
            {
                if (value > Birthdate)
                {
                    _dateOfDeath = value;
                }
                else
                {
                    Console.WriteLine("Error. Date of death should be greater than birthdate.");
                }
            }
        }

        public Person(string name, DateTime birthdate) : this(name, birthdate, DateTime.Now) { }
        public Person(string name, DateTime birthdate, DateTime dateOfDeath)
        {
            Name = name;
            Birthdate = birthdate;
            DateOfDeath = dateOfDeath;            
        }

        public void GetAge()
        {
            _age = DateOfDeath.Year - Birthdate.Year;

            if (Birthdate.Month < DateOfDeath.Month || (Birthdate.Month == DateOfDeath.Month & Birthdate.Day < DateOfDeath.Day))
            {
                _age--;
            }

            if (_age < 0)
            {
                Console.WriteLine("Error. Age is negative.");

                return;
            }                

            Console.WriteLine($"Age - {_age} years");
        }

        public Person GetChild()
        {
            Child child = new Child("", new DateTime((this.Birthdate.Year + 16), this.Birthdate.Month, this.Birthdate.Day)); // create default child
            bool flag = true;
            //bool isChild = true;

            while (flag)
            {
                child = new Child("", new DateTime((this.Birthdate.Year + 16), this.Birthdate.Month, this.Birthdate.Day)); // create default child

                Console.WriteLine("Gender of the child -  M/W ?");

                string selectGender = Console.ReadLine().ToLower();

                switch (selectGender)
                {
                    case "m":
                        {
                            child = CreateChild(child);

                            flag = child == null ? true : false;

                            break;
                        }
                    case "w":
                        {
                            child = CreateChild(child);
                            flag = child == null ? true : false;

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error! Choose M or W");

                            break;
                        }
                }
            }

            return child;
        }

        private Child CreateChild(Child child)
        {
            //Child child = new Child("", new DateTime((this.Birthdate.Year + 17), this.Birthdate.Month, this.Birthdate.Day)); // create default child
            //bool isCreate = true;

            Console.Write("Enter child name: ");

            child.Name = Console.ReadLine();

            Console.Write("\nEnter child birthdate (yyyy, mm, dd): ");

            bool isBirthdate = DateTime.TryParse(Console.ReadLine(), out DateTime birthdate);

            if (isBirthdate)
            {
                if (CheckChildAge(birthdate))
                {
                    child = new Child(child.Name, birthdate);
                }
                else
                {                    
                    child = null;
                    Console.WriteLine("Try again.");
                }
            }
            else
            {
                child = null;
            }
            
            // Create method
            Console.Write("Enter date of death (yyyy, mm, dd): ");                      

            bool isChildDateOfDeath = DateTime.TryParse(Console.ReadLine(), out DateTime datedeath);

            if (isChildDateOfDeath && datedeath > birthdate)
            {
                DateOfDeath = datedeath;
            }

            return child;
        }

        private bool CheckChildAge(DateTime birthdate)
        {
            bool bd = true;

            if ((birthdate.Year < (this.Birthdate.Year + 16)))
            {
                Console.WriteLine("Error! The wrong age of the child");
                bd = false;
            }

            return bd;
        }

        public void GetWife()
        {
            Name = Console.ReadLine();
            bool isBirthdate = DateTime.TryParse(Console.ReadLine(), out DateTime birthdate);
            Person wife = new Woman(Name, birthdate);
            Married = true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
