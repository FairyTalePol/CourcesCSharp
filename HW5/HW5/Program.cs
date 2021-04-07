using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tasks1_4();

            //Task5();

            //Task6();

            //Task7();

            //Task8();

            Task9();

            //Task10();
        }

        static void Task10()
        {
            int[] arr = ArrayInput();
            int imin = 0;
            for (int i=0; i<arr.Length;i++)
            {
                imin = MaxValuePos(arr, i);
                int temp = arr[i];
                arr[i] = arr[imin];
                arr[imin] = temp;
            }

            Console.WriteLine("Sorted array (select sort):");
            ArrayOutput(arr);
        }

        static int MaxValuePos(int[] arr, int startIndex)
        {
            int max = arr[startIndex];
            int imax = startIndex;
            for (int i =startIndex; i<arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                    imax = i;
                }
            }
            return imax;
        }
        static void Task9()
        {
            int[] arr = ArrayInput();
            int[] arr2 = (int[])arr.Clone();
            int count1 = 0;
            int count2 = 0;
            
            for (int j=0; j<arr.Length; j++)
                for (int i = 0; i < arr.Length - 1-j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        count1++;
                    }
                }

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = i + 1; j < arr2.Length; j++)
                {
                    if (arr2[i] > arr2[j])
                    {
                        int temp = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = temp;
                        count2++;
                    }
                }
            }

            Console.WriteLine("Sorted array (method from Wikipedia):");
            ArrayOutput(arr);
            Console.WriteLine("Sorted array (method from lecture):");
            ArrayOutput(arr2);
            Console.WriteLine($"Number of operations (wikipedia:lecture): {count1} : {count2}");
        }

        static void Task8()
        {
            int[] arr = ArrayInput();
            int mod = arr.Length % 2 == 0 ? 0 : 1;
            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length / 2 + i+mod];
                arr[arr.Length / 2 + i+mod] = temp;
            }

            ArrayOutput(arr);
        }

        static void Task7()
        {
            int[] arr = ArrayInput();
            int counter = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 != 0)
                    counter++;
            }
            Console.WriteLine($"Number of even elements of array is {counter}");
        }
        static void Task6()
        {
            int[] arr = ArrayInput();
            for (int i=0;i<arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            ArrayOutput(arr);
            
        }
        static void Task5()
        {
            int[] arr = ArrayInput();

            int sum = 0;
            for (int i=1; i<arr.Length; i+=2)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Summ of elements with even undexes is {sum}");
        }

        static void Tasks1_4()
        {
            int[] arr = ArrayInput();

            int imax = 0;
            int max = Max(arr, out imax);

            int imin = 0;
            int min = Min(arr, out imin);

            Console.WriteLine($"Min value of array is {min} at pos {imin}");
            Console.WriteLine($"Max value of array is {max} at pos {imax}");
        }

        static int Max(int[] arr, out int index)
        {
            int max = arr[0];
            index = 0;
            for (int i = 0; i < arr.Length; i++)
            {                
                if (arr[i]>max)
                {
                    max = arr[i];
                    index = i;
                }
            }
            return max;
        }

        static int Min(int[] arr, out int index)
        {
            int min = arr[0];
            index = 0;
            for (int i = 0; i < arr.Length; i++)
            {               
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            return min;
        }

        static int[] ArrayInput()
        {
            int size;
            Console.WriteLine("Enter array size");
            while (!int.TryParse(Console.ReadLine(), out size) || size < 0)
            {
                Console.WriteLine("Incorrect input");
            }
            int[] arr = new int[size];
            arr = FillArrayRandom(arr, 0, 10);
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            return arr;
        }

        static int[] FillArrayRandom(int[] array, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max);
            }
            return array;
        }

        static void ArrayOutput(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
