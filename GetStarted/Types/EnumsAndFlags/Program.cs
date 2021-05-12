using System;

namespace EnumsAndFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            var turnip = SomeRootVegetable.Turnip;
            SomeRootVegetable horseRadish = SomeRootVegetable.HorseRadish;

            Console.WriteLine(turnip);
            Console.WriteLine(horseRadish);

            Seasons spring = Seasons.Spring;
            Seasons startingOnEquinox = Seasons.Spring | Seasons.Autumn;
            Seasons thisYear = Seasons.All;

            Console.WriteLine(spring);
            Console.WriteLine(startingOnEquinox);
            Console.WriteLine(thisYear);
        }
    }
}
