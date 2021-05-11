using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(10, 20);

            Console.WriteLine($"Point p1: ({p1.X}, {p1.Y})");
            Console.WriteLine($"Point p2: ({p2.X}, {p2.Y})");
        }
    }
}
