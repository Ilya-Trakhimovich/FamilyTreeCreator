using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    class Man : Person
    {
        public bool IsMarried { get; set; } = false;

        public Woman Wife { get; set; }

        public Man(string name, int age) : base(name, age) { }

        public string job = GetWork();

        private static string GetWork()
        {
            string[] jobs = { "Engineer", "Doctor", "Builder", "Driver", "DJ", "Trainer", "Seller", "Architect" };

            Random rnd = new Random();

            int job = rnd.Next(0, 8);

            return jobs[job];
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
