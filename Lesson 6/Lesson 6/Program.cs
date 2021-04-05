using System;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            ArrayFillRandom(arr);

            Console.WriteLine(ToString(arr));

            Console.WriteLine("Enter min value:");
            Console.WriteLine($"Number of values bigget than min: {NumbersBiggerThanMin(arr, int.Parse(Console.ReadLine()))}");

            

            /*double sum = 0;           
            sum += arr[0,arr.GetLength(1)-1];
            sum += arr[0, 0];
            sum += arr[arr.GetLength(0) - 1,0];
            sum += arr[arr.GetLength(0) - 1,arr.GetLength(1) - 1];
            double avg = sum / 4;
            Console.WriteLine($"Summ = {sum}; avg = {avg}");*/



            Console.ReadKey();
            
        }

        static double NumbersBiggerThanMin(int[,] arr, int min)
        {
            int count = 0;
            foreach (var el in arr)
                if (el > min)
                    count++;
            return count;
        }

        static string ToString(int[,] arr)
        {
            string s = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    s += $"{arr[i, j]} \t";

                }             
                s += "\n";
            }
            return s;
        }
        static int[,] ArrayFillRandom(int[,] arr)
        {
            Random r = new Random();
            for (int i=0; i<arr.GetLength(0); i++)
                for (int j=0; j< arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(0, 100);
                }
            return arr;
        }
    }
}
