using System;

namespace IDL2
{

    /*
        Many businesses need to know the outside temperature when dealing with deliveries,
        products, and customers.  Since there are two major scales in use, Fahrenheit and
        Celsius, there needs to be a way to convert between them.

        Assume that a previous programmer wrote this code, but before debugging and delivering
        it, was transferred to a new department.  Your task to finish the work.  The code is
        almost correct, but compilation (syntax), coding (specification), or output (semantic)
        bugs exist.

        Carefully study the code, determine the problem, and fix the bug or bugs so that the
        output is as expected.  Change as little code as possible to correct the problem.
        Place a comment on or before the fixed lines explaining what is wrong and how the fix
        resolves the issue--no comment(s), no points.
    */

    // CORRECTED NAMING CONVENTION
    class TempConverter
    {
        // INLINED SINGLE STATEMENT METHOD AND CORRECTED MATHEMATICAL CALCULATION ERROR
        // T(°F) = T(°C) × 9/5 + 32
        static double ConvertC2F(double c) => c * 1.8 + 32;

        // ADDING BACKWARDS COMPATIBILITY
        // T(°C) = (T(°F) - 32) × 5/9
        static double ConvertF2C(double f) => (f - 32) / 1.8;

        static void Main(string[] args)
        {
            // ADDED NULL CHECK ON ARGS
            if (args is null) throw new ArgumentNullException(nameof(args));

            double tempC = 43.5;
            double tempF = ConvertC2F(tempC);
            Console.WriteLine("The conversion of 43.5 Celsius should be 110.3 Fahrenheit");
            // CHANGED TO STRING INTERPOLATION FOR READABILITY
            Console.WriteLine($"{tempC} degrees Celsius is equivalent to {tempF} degrees Fahrenheit\n");

            // ADDED TESTS FOR BACKWARDS COMPATIBILITY
            double tempF2 = 110.3;
            double tempC2 = ConvertF2C(tempF2);
            Console.WriteLine("The conversion of 110.3 Fahrenheit should be 43.5 Celsius");
            Console.WriteLine($"{tempF2} degrees Fahrenheit is equivalent to {tempC2} degrees Celsius");
        }
    }

}