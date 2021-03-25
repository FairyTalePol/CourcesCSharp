using System;
using System.Globalization;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //&& - проверяется до момента, пока будет гарантированный результат
            //& - проверяется всё
            //Аналогично для || |

            /*int a = 3;
            int b = 4;
            bool c = a == b;
            Console.WriteLine($"a = {a}; b = {b}");
            Console.WriteLine($"a == b is {c}");
            Console.WriteLine($"a != b is {a!=b}");
            Console.WriteLine($"a > b is {a>b}");
            Console.WriteLine($"a < b is {a<b}");
            Console.WriteLine();

            
            Console.WriteLine($"true || false ---> {true||false}");
            Console.WriteLine($"true && false ---> {true && false}");
            Console.WriteLine($"true | false ---> {true | false}");
            Console.WriteLine($"true & false ---> {true & false}");
            Console.WriteLine();

            int x = 1;
            int y = 1;
            int z = 1;
            Console.WriteLine($"true | z++ > y || z++ <  ---> {true | z++ > y || z++ < y}");
            Console.WriteLine(z);
            Console.WriteLine($"true | x++>y || x++<y ---> {true || x++>y || x++<y}");
            Console.WriteLine(x);
            Console.WriteLine($"true | y++ > x | y++ < x ---> {true | y++ > x | y++ < x}");
            Console.WriteLine(y);

            Console.WriteLine($"true == !false ---> {true==!false}");
            Console.WriteLine();

            Console.WriteLine($"true ^ true ---> {true^true}");
            Console.WriteLine($"true ^ false ---> {true ^ false}");
            Console.WriteLine($"false ^ false ---> {false ^ false}");
            Console.WriteLine();

            Console.WriteLine(10>5?"Da":"Net");
            Console.ReadKey();*/

            //double number = Convert.ToDouble(Console.ReadLine());
            /*if (double.TryParse(Console.ReadLine(), out double number))
            {
                string result = "=";
                if (number > 0)
                    result = ">";
                else if (number < 0)
                    result = "<";
                Console.WriteLine($"Number {result} 0;");
                Console.WriteLine();

                Console.WriteLine($"Number {(number > 0 ? '>' : (number < 0 ? '<' : '='))} 0;");
            }
            else
                Console.WriteLine("Entered value is not a number");
            Console.ReadKey();*/

            /*double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            string operand = Console.ReadLine();

            Console.WriteLine($"{(operand=="+"?(first+second):(operand=="-"?(first-second):("Wrong operand")))}");*/
            /*Console.WriteLine("Укажите язык программирования:");
            var lang = Console.ReadLine().ToUpper();
            var message = "Вы выбрали ";
            switch (lang)
            {
                case "C#":
                    Console.WriteLine($"{message} C#");
                    break;
                case "VB":
                    Console.WriteLine($"{message} Visual Basic");
                    break;
                case "C++":
                    Console.WriteLine($"{message} C++");
                    break;
                default:
                    Console.WriteLine("Такой язык я не знаю");
                    break;
            }*/

            /*Console.WriteLine("Укажите месяц: ");
            string season = "";
            if (Int32.TryParse(Console.ReadLine(), out int month))
            {
                switch (month)
                {
                    case 1:
                    case 2:
                    case 12:
                        Console.WriteLine("Зима");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Весна");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Лето");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Осень");
                        break;
                    default:
                        Console.WriteLine("Такого месяца нет");
                        break;
                }

                if (month == 1 || month == 2 || month == 12)
                    Console.WriteLine("Зима");
                else if (month == 3 || month == 4 || month == 5)
                    Console.WriteLine("Весна");
                else if (month == 6 || month == 7 || month == 8)
                    Console.WriteLine("Лето");
                else if (month == 9 || month == 10 || month == 11)
                    Console.WriteLine("Осень");
                else
                    Console.WriteLine("Такого месяца нет");

                season = (month == 1 || month == 2 || month == 12) ? "Зима" 
                    : (month == 3 || month == 4 || month == 5) ? "Весна" 
                    : (month == 6 || month == 7 || month == 8) ? "Лето" 
                    : (month == 9 || month == 10 || month == 11) ? "Осень" 
                    : "Такого месяца нет";

                Console.WriteLine(season);


            */

            double costType1 = 10;
            double costType2 = 15;
            double costType3 = 20;
            int size = Convert.ToInt32(Console.ReadLine());
            int amount = Convert.ToInt32(Console.ReadLine());
            string errorMsg = "Wrong input";

            double discount = amount > 10 ? (amount > 50 ? 0.85 : 0.9) : 1.0;
            double price = -1;
            switch(size)
            {
                case 1:
                    price = costType1 * amount * discount;
                    break;
                case 2:
                    price = costType2 * amount * discount;
                    break;
                case 3:
                    price = costType3 * amount * discount;
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            
            Console.WriteLine($"Итоговая цена: {price}");




        }
    }
}
