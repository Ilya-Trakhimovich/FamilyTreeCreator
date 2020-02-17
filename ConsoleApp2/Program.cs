using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();

            circle.Center = new Point { X = 0, Y = 0 };

            circle.Center.Move(5, 5);

            Console.WriteLine(circle.Center.X);
            Console.WriteLine(circle.Center.Y);
            
        }

        public struct Point
        {
            public int X;
            public int Y;

            public void Move(int dx, int dy)
            {
                X += dx;
                Y += dy;
            }
        }

        public class Circle
        {
            public Point Center { get; set; }
        }
    }
}
