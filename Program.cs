using System;

namespace homeWorkingWithSpecificRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minValue = 2;
            int maxValue = 5;
            int sum = 0;
            int secondRow = 1;
            int multiply = 1;
            int fistColumn = 0;

            int[,] array = new int[random.Next(minValue, maxValue), random.Next(minValue, maxValue)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                    if (i == secondRow)
                    {
                        sum += array[i, j];
                    }
                    if (j == fistColumn)
                    {
                        multiply *= array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nsum = {sum}");
            Console.WriteLine($"\nmultiply = {multiply}");
        }
    }
}
