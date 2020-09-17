using System;

/*
    Many businesses need to convert data from one format to another.  In this case, data
    is streamed in sequence, but the data needs to be represented as a two-dimensional
    array.  The idea is to convert the sequential data (vector) into a table (matrix),
    along the lines of a spreadsheet.

    Assume that a previous programmer wrote this code, but before debugging and delivering
    it, was transferred to a new department.  Your task to finish the work.  The code is
    almost correct, but compilation (syntax), coding (specification), or output (semantic)
    bugs exist.

    Carefully study the code, determine the problem, and fix the bug or bugs so that the
    output is as expected.  Change as little code as possible to correct the problem.
    Place a comment on or before the fixed lines explaining what is wrong and how the fix
    resolves the issue--no comment(s), no points.
*/
namespace FFTB05
{
    class MatrixTransformer
    {
        // create a matrix with row size of 'width' from the data in 'vector'
        // pad any empty (uninitialized) elements with -1
        static int[,] Transform(int width, int[] vector)
        {
            int rows = (int)Math.Ceiling((double)vector.Length / width);      // Explicitely cast Ceiling parameter as a Double (to avoid ambiguity with overloads) then cast result as Int
            int[,] matrix = new int[width, rows];                             // Reversed width and rows indices in matrix declaration
            int col = 0;
            int row = 0;
            foreach (int n in vector)
            {
                matrix[col, row] = n;                                         // Reversed column and row indices in matrix assignment
                if (++col == width)
                {
                    ++row;
                    col = 0;
                }
            }
            int pad = (rows * width) - vector.Length;
            for (int i = 0; i < pad; ++i)
                matrix[col + i, row] = -1;
            return matrix;
        }

        static void Main(string[] args)
        {
            if (args is null) throw new ArgumentNullException(nameof(args));

            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[,] table = Transform(3, data);
            Console.WriteLine("the new data in the table should be: ");
            Console.WriteLine("1 2 3\n4 5 6\n7 8 9\n10 -1 -1\n");
            Console.WriteLine("the new data in a table is:");
            for (int r = 0; r <= table.GetUpperBound(1); r++)
            {                                                              // Changed to <= and post-increment, and reversed matrix dimension bounds to correspond with matrix display requirements
                for (int c = 0; c <= table.GetUpperBound(0); c++)
                    Console.Write(table[c, r] + " ");
                Console.WriteLine();
            }
        }
    }
}