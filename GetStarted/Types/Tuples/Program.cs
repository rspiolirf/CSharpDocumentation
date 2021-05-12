using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (int I, string S) t1 = (4, "Mastering CSharp");
            Console.WriteLine(t1.I);
            Console.WriteLine(t1.S);
        }
    }
}
