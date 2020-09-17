/*
This program computes the average of a student's grades.

The expected output is:
	The average score is <something valid based on input>

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that
the program is working as expected.

 */

using System;

namespace IDL4
{
    public class CalculateAverageScore				// CORRECTED NAMING CONVENTION
    {
        public static void Main(string[] args)      // CORRECTED main TO Main
        {
            int count = 0;
            int total = 0;

            do
            {
                Console.Write("Input score (negative value to quit): ");
                int score = int.Parse(Console.ReadLine());
                if (score < 0) break;
                total += score;                     // CORRECTED ASSIGNMENT TO INCREMENTAL ASSIGNMENT
                ++count;
            } while (true);

            if (count == 0)                         // ADDED CHECK FOR DIVIDE BY ZERO ERROR
                Console.WriteLine("The average score is 0");
            else
                Console.WriteLine("The average score is " + total / count);
        }
    }
}
