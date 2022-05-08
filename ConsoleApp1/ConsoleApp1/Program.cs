using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int maxValue = int.MinValue;
            Random random = new Random();
            Console.WriteLine("Исходный массив\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 11);
                    Console.Write(array[i, j] + " ");

                    if (maxValue < array[i, j])
                    {
                        maxValue = array[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nмаксимальное значение в массиве {maxValue}\n");
            Console.WriteLine("Новый массив\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (maxValue == array[i, j])
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
