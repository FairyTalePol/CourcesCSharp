using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Понедельник 29.03
            //bool cont = true;
            //do
            //{
            //    Console.WriteLine("Enter number: ");
            //    string textInput = Console.ReadLine();
            //    if (!int.TryParse(textInput, out int number))
            //    {
            //        if (double.TryParse(textInput, out double tempr))
            //        {
            //            Console.WriteLine("The number is not prime");
            //            continue;
            //        }

            //        Console.WriteLine("Enter vallid numer");
            //        continue;
            //    }
            //    Console.WriteLine($"The number {number} is {(Prime(number)?"":"not ")}prime");
            //    Console.WriteLine("Want to continue? (y/n)");
            //    cont = Console.ReadLine().Equals("y") ? true : false;

            //} while (cont);

            //вводим 2 числа. найти их наибольший общий делитель через эвклида. натуральные числа


            /*int a = GuaranteedNaturalRead("Enter natural number;", "Wrong input");
            int b = GuaranteedNaturalRead("Enter natural number;", "Wrong input");
            Console.WriteLine($"НОД ({a},{b}) = {Euclidus(a, b)}");*/



            //n-e число ряда фибоначи
            int a = GuaranteedNaturalRead("Enter natural number;", "Wrong input");
            Console.WriteLine(Fibonacci(a));


        }

        public static int Fibonacci(int n)
        {
            if (n<3)
                return 1;
            return Fibonacci(n-1)+Fibonacci(n-2);
        }

        public static int Euclidus(int bigger, int smaller)
        {

            while (bigger!=smaller && bigger>0 &&smaller >0)
            {
                if (bigger<smaller)
                {
                    int help = smaller;
                    smaller = bigger;
                    bigger = help;
                }
                bigger = bigger - smaller;
            }
            return bigger<smaller?bigger:smaller;
        }

        static bool Prime(double number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i < number / 2 +1; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        private static int GuaranteedIntRead(string normalMessage, string errorMessage)
        {
            int returnValue;
            Console.WriteLine(normalMessage);
            do
            {
                string readValue = Console.ReadLine();
                if (int.TryParse(readValue, out returnValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            } while (true);
            return returnValue;
        }

        private static int GuaranteedNaturalRead(string normalMessage, string errorMessage)
        {
            int enteredNumer = 0;
            while (true)
            {
                enteredNumer = GuaranteedIntRead(normalMessage, "Invalid input. Integer value expected");
                if (enteredNumer < 1)
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    break;
                }
            }
            return enteredNumer;
        }
    }
}
