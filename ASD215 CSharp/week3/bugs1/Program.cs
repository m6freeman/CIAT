using System;

/*
    Many businesses need to shipping costs for products they deliver.  A customer usually
    gets a price break for more items ordered.  Often, the prices for shipping are put
    into ranges of weights, only changing as a threshold is reached.

    Assume that a previous programmer wrote this code, but before debugging and delivering
    it, was transferred to a new department.  Your task to finish the work.  The code is
    almost correct, but compilation (syntax), coding (specification), or output (semantic)
    bugs exist.

    Carefully study the code, determine the problem, and fix the bug or bugs so that the
    output is as expected.  Change as little code as possible to correct the problem.
    Place a comment on or before the fixed lines explaining what is wrong and how the fix
    resolves the issue--no comment(s), no points.
*/
namespace bugs1
{
    // CHANGED CLASS NAME CONVENTION
    class ShippingWeightPriceCalc
    {
        /*
        Determine shipping cost based on weight:
        for up to 1 lb., $3.50;
        for up to 3 lb., $5.50;
        for up to 10 lb., $8.50;
        for up to 20 lb., $10.50;
        for more than 20 lb. issue a message "the package must be shipped by another carrier".
         */

         // CHANGES: MADE RETURN TYPE OF METHOD DYNAMIC TO ACCOMMODATE DOUBLES AND STRINGS
         //          CORRECTED LOGIC ERROR FROM < TO <=
         //          ADDED FINAL ELSE CLAUSE TO CATCH > 20 CASE
        static dynamic ComputeCost(double weight)
        {
            if (weight <= 1)
                return 3.5;
            else if (weight <= 3)
                return 5.5;
            else if (weight <= 10)
                return 8.5;
            else if (weight <= 20)
                return 10.5;
            else
                return "the package must be shipped by another carrier";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Expected cost for 2 lb. is 5.5");
            Console.WriteLine("Actual  cost  for 2 lb. is " + ComputeCost(2));
            Console.WriteLine("Expected cost for 10 lb. is 8.5");
            Console.WriteLine("Actual  cost  for 10 lb. is " + ComputeCost(10));
            Console.WriteLine("Expected cost for 22 lb. is an error message");
            Console.WriteLine("Actual  cost  for 22 lb. is " + ComputeCost(22));
        }
    }
}