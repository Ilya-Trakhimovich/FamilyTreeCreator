using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person yurcha = new Man("Yurcha", new DateTime(2000, 11, 3));
            Person yulia = new Woman("Yulia", new DateTime(1999, 10, 4), new DateTime(2013, 1, 1));
            Person marina = new Woman("Marina", new DateTime(1992, 10, 4));
            Person kirill = new Man("Kirill", new DateTime(2013, 5, 5));

            Man ilya = new Man("Ilya", new DateTime(1992, 06, 30));
            //Console.WriteLine(ilya);
            Person chuildIlya = ilya.GetChild();

            Console.WriteLine(ilya);
            Console.WriteLine(chuildIlya);
            Person mer = chuildIlya.GetChild();
            Console.WriteLine(mer);


            Console.ReadLine();
        }
    }
}
