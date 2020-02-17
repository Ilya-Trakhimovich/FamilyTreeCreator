using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTreeCreator_v2
{
    class Woman : Person
    {
        public bool IsMarried { get; set; } = false;

        public Man Husband { get; set; }

        public Woman(string name, int age) : base(name, age) { }

        public string job = GetWork();

        private static string GetWork()
        {
            string[] jobs = { "Teacher", "Doctor", "Dancer", "TV presenter", "Trainer", "Seller", "Bookkeeper", "Artist"};

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
