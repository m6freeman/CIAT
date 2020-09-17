/*
This program computes the average of a student's grades.

The expected output is:
	The average score is 70

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that
the program is working as expected.

 */

using System;

namespace bugs2
{

    // CORRECTED NAMING CONVENTION AND BRACES. THIS ISN'T JAVASCRIPT, AND WE'RE NOT MONSTERS
    public class Average
    {
        public static void Main(string[] args)
        {
            double[] grades = { 90, 80, 70, 60, 50 };
            // CORRECTED RECEIVING VARIABLE DATATYPE
            double average = ComputeAverage(grades);
            Console.WriteLine("The average score is " + average);
        }

        // NAMING CONVENTION
        public static double ComputeAverage(double[] grades)
        {
            double sum = 0.0;
            // REMOVED REDUNDANT VARIABLE ASSIGNMENT
            // REMOVED UNNECESSARY COUNT VARIABLE

            // WE'RE ITERATING OVER A FINITE COLLECTION, ITS BETTER TO USE FOREACH.
            // NOT SURE WHAT KIND OF MATHAMAGICS THEY TRIED PULLING HERE, SO WE'LL
            // JUST DO A PROPER AVERAGE INSTEAD.
            foreach (var grade in grades) sum += grade;
            double average = sum / grades.Length;
            return average;
        }
    }
}