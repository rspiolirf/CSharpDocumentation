using System;

namespace NullableTypes
{
    #nullable enable
    
    class Program
    {
        static void Main(string[] args)
        {
            int? optionalInt = default;
            optionalInt = 5;
            Console.WriteLine(optionalInt);

            string? optionalString = default;
            optionalString = "Hello CSharp!";
            Console.WriteLine(optionalString);
        }
    }
}
