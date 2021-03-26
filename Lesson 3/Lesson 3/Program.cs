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
           
          

            Console.ReadKey();
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
