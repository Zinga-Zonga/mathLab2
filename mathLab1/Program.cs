using System;
using System.Text;
using static mathLab1.MachineZeroInf;

namespace mathLab1
{
    internal class Program
    {
        static double[,] gaussAlgorithm(double[,] matrix)
        {
            double k;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    k = matrix[i, j];
                    if (matrix[i, j] != 1)
                    {
                        for (int n = j; n <= matrix.GetLength(0); j++)
                        {
                            matrix[n, j] /= k;
                        }
                    }
                    
                            

                    Console.WriteLine($"Получили единицу в {i + 1}-ем столбце, разделив {i + 1}-ю строку на {k}");
                    printMatrix(matrix);
                    Console.WriteLine();

                    //for (int i = 0; i <= 7; i++)
                    //{
                    //    if (i == m) continue;
                    //    k = matrix[i, n];
                    //    for (int j = n; j <= 8; j++)
                    //        matrix[i, j] -= matrix[m, j] * k;
                    //}
                }
            }
            //double k = matrix[m,n];
            //if (matrix[m, n] != 1)
            //    for (int j = n; j <= 8; j++)
            //        matrix[m, j] /= k;

            //Console.WriteLine($"Получили единицу в {m + 1}-ем столбце, разделив {m + 1}-ю строку на {k}");
            //printMatrix(matrix);
            //Console.WriteLine();

            //for (int i = 0; i <= 7; i++)
            //{
            //    if (i == m) continue;
            //    k = matrix[i, n];
            //    for (int j = n; j <= 8; j++)
            //        matrix[i, j] -= matrix[m, j] * k;
            //}

            //Console.WriteLine($"Занулили {m + 1}-ий столбец");
            return matrix;
            
        }
        
        static void printMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    Console.Write(String.Format("{0,9}", matrix[i, j].ToString("G3")));

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static double[,] fillHilbertMatrix(double[,] matrix)
        {
            double[,] hilbertMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    hilbertMatrix[i, j] = (double)1.0 /
                            ((i + 1) + (j + 1) -
                            (double)1.0);
                }
            }
            return hilbertMatrix;
        }
        static void Main(string[] args)
        {
            double[,] matrix = new double[11, 11];
            double[,] matrix2 = fillHilbertMatrix(matrix);
            Console.WriteLine("Матрица Гильберта");
            printMatrix(matrix2);
            printMatrix(gaussAlgorithm(matrix2));
        }

    }
}
