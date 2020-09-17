using System;

namespace chapterTwoProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Distance d = new Distance(4.5f, DistanceUnits.MILES);
            System.Console.WriteLine("{0,8}\t{1,8}\t{2,8}",
                DistanceUnits.FEET, DistanceUnits.KILOMETERS, DistanceUnits.MILES);
            System.Console.WriteLine("{0,8}\t{1,8}\t{2,8}",
                d.Feet.ToString("#,0"), d.Kilometers, d.Miles);

        }
    }
}
