using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum1to99();

            /*for (int i=0;i<150;i++)
            {
                Console.WriteLine($"i={i}; prime={Prime(i)}");
            }*/

            //Console.WriteLine(Sqrt(44));

            //Console.WriteLine(Factorial(6));

            //SummCifr(553);

            //Console.WriteLine(CountNumbers(123));

            Console.WriteLine(Mirror(-1423523));

            Console.ReadKey();
        }

        static void Sum1to99()
        {
            int counter = 0;
            int sum = 0;
            for (int i = 2; i < 100; i += 2)
            {
                sum += i;
                counter++;
                //Console.WriteLine($"i={i}; counter={counter}; sum = {sum}");
            }
            Console.WriteLine($"Sum = {sum}, number = {counter}");
        }

        static bool Prime(double number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static int Sqrt(int number)
        {

            for (int i = 0; i <= number / 2 + 1; i++)
            {
                if (i * i > number)
                    return i - 1;
            }
            return 1;
        }

        static double Factorial(double n) //здесь есть условие на целое число?
        {
            double res = 1;
            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
                temp++;
            }
            return res;
        }

        static double SummCifr(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
                //Console.WriteLine($"Sum = {sum}; n = {n}");
            }
            Console.WriteLine(sum);
            return 1;
        }

        public static int Mirror(int number) //Дописать условие для отрицательных чисел
        {
            int mirror = 0;
            int count = CountNumbers(number);
            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine($"i = {i}; number = {number}; number%10 = {number%10}");
                mirror += MultiplyBy10(number % 10, count - i - 1);
                number = number / 10;
                //Console.WriteLine($"Mirror = {mirror}; number = {number}");
            }
            return mirror;
        }

        public static int CountNumbers(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                number = number / 10;
                counter++;
            }
            return counter;
        }

        public static int MultiplyBy10(int number, int count)
        {
            for (int i = 0; i < count; i++)
                number *= 10;
            return number;
        }



    }
}