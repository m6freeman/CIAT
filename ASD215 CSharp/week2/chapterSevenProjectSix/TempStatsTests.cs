using System;

namespace chapterSevenProjectSix
{
    class TempStatsTests
    {
        /*
        return highest, average, average excluding lowest, and lowest temperature.
        Override the ToString method to return a listing of all the temperatures
        in three-column format and the temperature range for the given week
        Provide a method that accepts as an argument a temperature
        and returns the number of days the temperatures were below that value
        */

        public static void GetHighest_ReturnsTheHighestValueInArray()
        {
            if (new TempStats(temps: new int[] { 1, 2, 3 }).GetHighest() == 3)
                Console.WriteLine("Success");
            else
            {
                Console.WriteLine("Failure");
                Console.WriteLine(new TempStats(temps: new int[] { 1, 2, 3 }).GetHighest());
            }
        }

        public static void GetAverage_ReturnsTheAverageValueInArray()
        {
            if (new TempStats(temps: new int[] { 1, 2, 3 }).GetAverage() == 2)
                Console.WriteLine("Success");
            else
            {
                Console.WriteLine("Failure");
                Console.WriteLine(new TempStats(temps: new int[] { 1, 2, 3 }).GetAverage());
            }
        }

        public static void GetAverageExcludingLowest_ReturnsTheAverageValueExcludingLowestInArray()
        {
            if (new TempStats(temps: new int[] { 5, 2, 3 }).GetAverageExcludingLowest() == 4)
                Console.WriteLine("Success");
            else
            {
                Console.WriteLine("Failure");
                Console.WriteLine(new TempStats(temps: new int[] { 5, 2, 3 }).GetAverageExcludingLowest());
            }
        }

        public static void GetLowest_ReturnsLowestValueInArray()
        {
            if (new TempStats(temps: new int[] { 1, 2, 3 }).GetLowest() == 1)
                Console.WriteLine("Success");
            else
            {
                Console.WriteLine("Failure");
                Console.WriteLine(new TempStats(new int[] { 1, 2, 3 }).GetLowest());
            }
        }

        public static void ToString_ReturnsPrintableListOfAllTemps()
        {
            Console.WriteLine(new TempStats(temps: new int[] { 1, 2, 3, 4, 5, 6 }));
        }

        public static void GetNumberOfTempsLowerThan_ReturnsTheNumberOfDaysBelowAProvidedTemp()
        {
            if (new TempStats(temps: new int[] { 1, 2, 3 }).GetNumberOfTempsLowerThan(3) == 2)
                Console.WriteLine("Success");
            else
            {
                Console.WriteLine("Failure");
                Console.WriteLine(new TempStats(temps: new int[] { 1, 2, 3 }).GetNumberOfTempsLowerThan(3));
            }
        }


        static void Main(string[] args)
        {
            if (args is null) throw new ArgumentNullException(nameof(args));

            Console.Write("Testing GetHighest: ");
            GetHighest_ReturnsTheHighestValueInArray();

            Console.Write("Testing GetAverage: ");
            GetAverage_ReturnsTheAverageValueInArray();

            Console.Write("Testing GetAverageExcludingLowest: ");
            GetAverageExcludingLowest_ReturnsTheAverageValueExcludingLowestInArray();

            Console.Write("Testing GetLowest: ");
            GetLowest_ReturnsLowestValueInArray();

            Console.Write("Testing ToString: ");
            ToString_ReturnsPrintableListOfAllTemps();

            Console.Write("Testing GetNumberOfTempsLowerThan: ");
            GetNumberOfTempsLowerThan_ReturnsTheNumberOfDaysBelowAProvidedTemp();

        }
    }
}
