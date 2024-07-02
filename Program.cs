using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkingWithSpecificRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minValue = 2;
            int maxValue = 5;
            int sumSecondRow = 0;
            int multiplyFistColumn = 1;

            int[,] array = new int[random.Next(minValue, maxValue), random.Next(minValue, maxValue)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                    if (i == 1)
                    {
                        sumSecondRow += array[i, j];
                    }
                    if (j == 0)
                    {
                        multiplyFistColumn *= array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nsum = {sumSecondRow}");
            Console.WriteLine($"\nmultiply = {multiplyFistColumn}");
        }
    }
}
