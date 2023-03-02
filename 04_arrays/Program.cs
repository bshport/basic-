using System;

namespace _04_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------- one-dimensions arrays
            //create array: type[] name = new [size] {value1, value2 ...}

            int[] numbers = { 3, 5, 6, 7, 2, 23, 6, 3, 6, 7, 1 };

            //get element by index

            numbers[0] = 777;
            Console.WriteLine($"First element: {numbers[0]}");

            Console.WriteLine($"Array type: {numbers.GetType()}");
            Console.WriteLine($"Array element type: {numbers[0].GetType()}");

            numbers.SetValue(99, 2);
                Console.WriteLine($"3 element: {numbers[2]}");

            Console.WriteLine(($"Length: {numbers.Length}"));
            Console.WriteLine($"Length 1 dimension: {numbers.GetLength(0)}");

            //----------------------- two-dimensions arrays
            int[,] matrix = new int[3, 4] {
                                              { 0, 1, 2, 3 },
                                              { 4, 5, 6, 7 },
                                              { 8, 9, 10, 11 }
                                           };
            Console.WriteLine(matrix.Length);
            Console.WriteLine($"Item: {matrix[1,0]}");
            Console.WriteLine($"1 dim length: {matrix.GetLength(0)}");
            Console.WriteLine($"2 dim length: {matrix.GetLength(1)}");
            Console.WriteLine($"matrix rank: {matrix.Rank}");


            Array.Reverse(numbers);
            //перебір з допомогою цикла реверсованого масиву
            Console.WriteLine("\n--Reverse Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i}: {numbers[i]}");
            }

            Array.Sort(numbers);
            //перебір з допомогою цикла посортованого масиву
            Console.WriteLine("\n--Sort Array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i}: {numbers[i]}");
            }
        }
    }
}
