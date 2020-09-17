/*
This program computes the average of a student's grades.

The expected output is:
The sales for today is 104.65

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that
the program is working as expected.

*/
using System;

namespace IDL1
{
    public class Tasties
    {
        public static void Main(string[] args)
        {
            // CHANGED VALUE FROM 421 TO 420
            double numberManufactured = 420;
            double numberPerBox = 12;

            // CHANGED OPERATOR FROM MODULO TO DIVISION
            double boxesSold = numberManufactured / numberPerBox;

            // CHANGED DATATYPE FROM INT TO DOUBLE
            double costPerBox = 2.99;
            double sales = boxesSold * costPerBox;

            // CHANGED STRING FORMAT OUTPUT TO CURRENCY
            Console.WriteLine("The sales for today is " + sales.ToString("c2"));
        }
    }
}
