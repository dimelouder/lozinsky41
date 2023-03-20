using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] masses = { 10.5, 20.1, 7.8, 15.3, 12.6 };

            double totalMass = 0.0;
            for (int i = 0; i < masses.Length; i++)
            {
                totalMass += masses[i];
            }

            Console.WriteLine("Общая масса груза:" + totalMass + "kg");


            double[] heights = { 170.2, 173.5, 165.1, 177.8, 169.4 };
            double averageHeight = 0.0;
            for (int i = 0; i < heights.Length; i++)
            {
                averageHeight += heights[i];
            }
            averageHeight /= heights.Length;

            Console.WriteLine("Средний рост студентов :" + averageHeight + "см");

            int[] arr = new int[15];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 11);
            }

            int negativeCount = 0;
            int positiveCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else if (arr[i] > 0)
                {
                    positiveCount++;
                } else
                {
                    zeroCount++;
                }
            }

            Console.WriteLine("Количество отрицательных элементов :" + negativeCount);
            Console.WriteLine("Количество положительных элементов :" + positiveCount);
            Console.WriteLine("Количество нулевых элементов :" + zeroCount);


            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество четных элементов:" + count);
        }
    }
}
