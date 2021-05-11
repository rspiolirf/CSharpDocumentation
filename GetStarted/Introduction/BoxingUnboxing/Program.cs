using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            object o = i; // boxing
            int j = (int)o; // unboxing

            Console.WriteLine($"i: {i}");
            Console.WriteLine($"o: {o}");
            Console.WriteLine($"j: {j}");
        }
    }
}
