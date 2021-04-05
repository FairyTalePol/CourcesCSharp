using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 4, 3, 1 };
            int[] sorted = BubbleSort(array);
            foreach(var el in sorted)
            {
                Console.Write(el+"\t");
            }
        }
        
        //3 2
        //5 2
        //5 3
        //2 3

        static int[] BubbleSort(int[] arr)
        {
            for (int i=1;i<arr.Length;i++)
            {
                if (arr[i]<arr[i-1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
            }
            return arr;
        }

        public static void CloneTest()
        {
            //MaxElOfArray();
            SimpleClass a = new SimpleClass();
            a.value = "Sample";
            SimpleClass b = new SimpleClass();
            b.value = "text";
            SimpleClass c = new SimpleClass();
            c.value = "ORIGINAL TEXT";

            SimpleClass[] arr1 = { a, b, c };
            SimpleClass[] arr2 = arr1;
            SimpleClass[] arr3 = (SimpleClass[])arr1.Clone();

            Console.Write("arr1 before change:\t");
            foreach (var el in arr1)
            {
                Console.Write(((SimpleClass)el).value + "\t");
            }
            Console.WriteLine();

            Console.Write("arr2 before change:\t");
            foreach (var el in arr2)
            {
                Console.Write(((SimpleClass)el).value + "\t");
            }
            Console.WriteLine();

            Console.Write("arr3 before change:\t");
            foreach (var el in arr3)
            {
                Console.Write(((SimpleClass)el).value + "\t");
            }
            Console.WriteLine();

            arr1[2].value = "CHANGED TEXT";

            Console.Write("arr1 after change:\t");
            foreach (var el in arr1)
            {
                Console.Write(((SimpleClass)el).value + "\t");
            }
            Console.WriteLine();

            Console.Write("arr2 after change:\t");
            foreach (var el in arr2)
            {
                Console.Write(((SimpleClass)el).value + "\t");
            }
            Console.WriteLine();

            Console.Write("arr3 after change:\t");
            foreach (var el in arr3)
            {
                Console.Write(((SimpleClass)el).value + "\t");
            }
            Console.WriteLine();



            Console.ReadKey();
        }

        static void TasksFrom1to4()
        {
            int arrSize;
            while (!int.TryParse(Console.ReadLine(), out arrSize))
            {
                Console.WriteLine("Incorrect input");
            }
        }

        public static void MaxElOfArray()
        {
            int arrSize;
            Console.WriteLine("Enter array size");
            while (!int.TryParse(Console.ReadLine(), out arrSize) || arrSize < 1)
            {
                Console.WriteLine("Incorrect input, positivte integer expected;");
            }

            int[] arr = new int[arrSize];
            Console.WriteLine("Enter elements of array");
            for (int i = 0; i < arr.Length; i++)
            {

                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Incorrect input, integer expected;");
                }
                arr.SetValue(num, i);
            }

            Console.WriteLine();
            Console.Write("Array: \t");
            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine("\n");
            int max = (int)arr.GetValue(0);
            foreach (var el in arr)
            {
                if (el > max)
                    max = el;
            }
            Console.WriteLine($"Max = {max}");

            Console.ReadKey();
        }

        class SimpleClass
        {
            public string value;
        }
    }
}
