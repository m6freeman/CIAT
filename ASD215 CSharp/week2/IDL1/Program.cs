using System;

namespace IDL1
{
	// CORRECTED NAMING CONVENTION
    public class Smallest {
		public static void Main(string[] args) {

			// NULL CHECK ON ARGS
            if (args is null) throw new ArgumentNullException(nameof(args));

            int[,] matrix = { {2, 6, 9}, {4, 4, 9}, {6, 3, 8}, {4, 7, 1} };

			// INCREASED LOWER BOUND FOR COMPARISON
			int small = 9;

			// CORRECTED SYNTAX ERROR , TO ; IN FOR STRUCTURE
			// CORRECTED PRE-INCREMENT TO POST-INCREMENT
			for (int i = 0; i < matrix.GetLength(0); i++)
				// INCREASED ARRAY.GETLENGTH DEPTH RANGE
				for (int j = 0; j < matrix.GetLength(1); j++)
					if (matrix[i,j] < small)
						small = matrix[i,j];

			Console.WriteLine("The smallest value is " + small);
		}
	}
}


/*
This program computes the average of a student's grades.

The expected output is:
	The smallest value is 1

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that
the program is working as expected.

 */
