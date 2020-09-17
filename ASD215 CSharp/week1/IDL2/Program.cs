/*
    Many businesses use linear algebra to solve problems dealing with efficiency, cost, and
    scheduling.  Below is a pair of linear equations where the values of x and y need to be
    computed from input values.

    Assume that a previous programmer wrote this code, but before debugging and delivering
    it, was transferred to a new department.  Your task to finish the work.  The code is
    almost correct, but compilation (syntax), coding (specification), or output (semantic)
    bugs exist.

    Carefully study the code, determine the problem, and fix the bug or bugs so that the
    output is as expected.  Change as little code as possible to correct the problem.
    Place a comment on or before the fixed lines explaining what is wrong and how the fix
    resolves the issue--no comment(s), no points.
*/
using System;

namespace IDL2
{
    class Driver
    {
        /*
            Cramer's rule states that if:
            ax + by = e     and     cx + dy = f

            then:
                ed - bf                 af - ec
            x = -------     and     y = -------
                ad - bc                 ad - bc
        */
        static void Solve(out double x, out double y, double a, double b, double e,
            double c, double d, double f)
        {
            // EXPLICITELY GROUPING EQUATION WITH PARENTHESIS
            x = ((e * d) - (b * f)) / ((a * d) - (b * c));
            y = ((a * f) - (e * c)) / ((a * d) - (b * c));
        }

        static void Main(string[] args)
        {
            double x, y;
            //    3.4x + 50.2y = 44.5     and     2.1x + 0.55y = 5.9
            Solve(out x, out y, 3.4, 50.2, 44.5, 2.1, 0.55, 5.9);
            Console.WriteLine("x should equal 2.62390149686142, and y should equal 0.708739739256398");

            // CHANGED STRING FORMATTING TO MATCH EXPECTED DECIMAL PRECISION
            Console.WriteLine("x computed is: {0}, and y computed is: {1}", x.ToString("n14"), y.ToString("n15"));
        }
    }
}
