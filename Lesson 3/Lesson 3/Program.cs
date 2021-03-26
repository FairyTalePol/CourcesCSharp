using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Example();
            ExampleWithText("GayBar");
            var text = ExampleString();
            Console.WriteLine(text);*/


            /*for, foreach, while, do...while*/

            /*for (int i=0;i<10;i++)
            {
                Console.WriteLine($"Years to communism: {10-i}");
            }*/

            //Pow2to5();

            //SlomatVseNahuj(1);

            //ForInsideFor();


            /*Exmaple3();

            Console.ReadKey();*/

            //Example4();

            //Sum1to10();

            //Console.WriteLine(Mul1to10());
            bool cont = true;
            do
            {
                Console.WriteLine("Введите два числа;");
                Console.WriteLine(Pow(2, 8));
                Console.WriteLine("Продолжить? (y)");
                cont = Console.ReadLine() == "y" ? true : false;
            } while (cont);
          

        }

        public static double Pow(int a, int b)
        {
            double res = 1;
            if (b>=0)
            {
                int i = 0;
               
                while (i < b)
                {
                    res = res * a;
                    i++;
                }
            }
            else
            {           
                res = 1 / Pow(a, b*(-1));
            }
            
            return res;

        }

        public static int Mul1to10()
        {
           
            int res = 1;
            for (int i=1;i<=10;i++)
            {
                res *= i;
            }
            return res;
        }

        public static void Sum1to10()
        {
            int i = 0;
            int sum = 0;
            do
            {
                i++;
                sum += i;

            } while (i < 10);
            Console.WriteLine(sum);
        }

        public static void Example4()
        {
            int i = 10;
            while (i>0)
            {
               
                if (i == 5)
                    continue;
                Console.WriteLine(i--);

            }
        }

        private static void Exmaple3()
        {
            Console.WriteLine("Укажите количество повторений");
            //int n = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Впишите имя и фамилию");
                    string name = Console.ReadLine();
                    string lastName = Console.ReadLine();
                    Console.WriteLine($"Your name is {name}, last name is {lastName}");
                }
            }

        }

        private static void ForInsideFor()
        {
            for (int i=0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"i={i};j={j}\t");
                }
                Console.WriteLine("\n");
            }
               
        }

        private static void SlomatVseNahuj(int i)
        {
            int b = ++i;
            Console.WriteLine(b);
            SlomatVseNahuj(b);

        }

        private static void Pow2to5()
        {
            Console.WriteLine("Введите положительное целое n;");
            if (int.TryParse(Console.ReadLine(), out int n)){
                for (int i = 0; i < n; i++)
                {
                    if (i > 2 && i < 5)
                        Console.WriteLine($"i^2 = {Math.Pow(i, 2)}");
                }
            }
            else
            {
                Pow2to5();
            }

            
           
        }
        
        private static void Example()
        {
            Console.WriteLine("Example");
        }

        private static void ExampleWithText(string text)
        {
            Console.WriteLine($"{text}");
        }

        private static string ExampleString()
        {
            return "GayBarString";
        }
    }
}
