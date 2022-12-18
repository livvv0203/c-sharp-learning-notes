using System;

namespace c_sharp_learning
{
    class Program
    {
        // Two dimensional array
        static int[,] matrix =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        public static void showDiagnoOf2DMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // go through the second dimension 
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        //  matrix[i, j] = 222;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// This is the entry point 
        /// </summary>
        public static void Main(string[] args)
        {
            showDiagnoOf2DMatrix(matrix);
        }
    }
}




























