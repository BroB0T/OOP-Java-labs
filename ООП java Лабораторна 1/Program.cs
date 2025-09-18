using System;
using System.Collections.Generic;

using static System.Math;
class Program
{
    // task 1
    static List<double> yValues = new List<double>();

    // task 2
    static double[,] matrix = new double[10, 10];
    static List<double> largestValues = new List<double>();


    static void Main()
    {
        Random random = new Random();


        Console.WriteLine("Task 1\n");

        for (double x = 0d; x <= 10d; x++)
        {
            yValues.Add(Pow(2d * Pow(x, 2d) + 5d * x, 0.5d));

            Console.WriteLine(x + "\t" + yValues[(int)x].ToString("F2"));
        }

        Console.WriteLine("\n");

        yValues.Clear();

        int listIndex = 0;
        for (double x = -2d; x <= 4d; x += 0.5d)
        {
            if (x < 0) yValues.Add(Cos(Sin(x + 2)));
            else yValues.Add(Sin(Pow(Cos(x), 2)));

            Console.WriteLine(x.ToString("F1") + "\t" + yValues[listIndex].ToString("F2"));
            listIndex++;
        }

        Console.WriteLine("\n\nTask 2");

        for (int i = 0; i < 10; i++)
        {
            double largestValue = -1;
            for (int u = 0; u < 10; u++)
            {
                matrix[i, u] = random.NextDouble() * 100;
                Console.Write(matrix[i, u].ToString("F1") + "\t");

                if (largestValue < matrix[i, u]) largestValue = matrix[i, u];
            }

            largestValues.Add(largestValue);
            Console.Write("\n");
        }

        Console.WriteLine("\nLargest value of every column: ");
        for (int i = 0; i < largestValues.Count; i++)
        {
            Console.WriteLine(largestValues[i].ToString("F1"));
        }
    }
}


