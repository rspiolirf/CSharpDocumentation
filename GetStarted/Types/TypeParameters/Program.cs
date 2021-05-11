using System;

namespace TypeParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<string, string> p1 = new Pair<string, string>("id", "8hdh46ffs3738sloi4");

            Console.WriteLine($"First: {p1.First}");
            Console.WriteLine($"Second: {p1.Second}");
        }
    }
}
