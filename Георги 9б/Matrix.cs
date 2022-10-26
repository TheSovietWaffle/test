using System;

namespace Enter_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Въведете брой колони: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Въведете пореден елемент: ");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int row = 0; row < rows; row++)
            {
                int min = matrix[row, 0];
                int max = matrix[row, 0];
                double avg = 0;

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + "  ");
                    avg += matrix[row, col];

                    if (matrix[row, col] < min)
                        min = matrix[row, col];

                    if (matrix[row, col] > max)
                        max = matrix[row, col];
                }
                avg = avg / matrix.GetLength(1);
                Console.Write("  average = " + Math.Round(avg, 2));
                Console.Write("  min = " + min + "  max = " + max);
                Console.WriteLine();
            }

            for(int col = 0; col < cols; col++)
            {
                int min = matrix[0, col];
                int max = matrix[0, col];
                double avg = 0;
                int counter = col + 1;

                for (int row = 0; row < rows; row++)
                {
                    avg += matrix[row, col];

                    if (matrix[row, col] < min)
                        min = matrix[row, col];

                    if (matrix[row, col] > max)
                        max = matrix[row, col];

                    Console.WriteLine();
                    
                }
                avg = avg / matrix.GetLength(0);
                Console.WriteLine("Колона номер " + counter);
                Console.WriteLine("average = " + Math.Round(avg, 2));
                Console.WriteLine("min = " + min);
                Console.WriteLine("max = " + max);
            }
            Console.WriteLine();
            Console.WriteLine("Въведете параметрите на елемент, който да бъде изведен: ");
            Console.Write("Въведете ред: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Въведете колона: ");
            int col1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (row1 > 0 && row1 <= rows && col1 > 0 && col1 <= cols)
                Console.WriteLine("Елементът е: " + matrix[row1 - 1, col1 - 1]);

            else
                Console.WriteLine("Грешни параметри! ");

            Console.ReadKey();

        }
    }
}
