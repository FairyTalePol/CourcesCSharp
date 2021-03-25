using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 1*/
            /*Console.WriteLine("Enter two numbers, each on new line;");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double result = a > b ? a + b : a < b ? a - b : a * b;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();*/

            /*Task 2*/

            /*Console.WriteLine("Enter X and Y, one on each line;");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            int quarter;
            if (x > 0)
                if (y > 0)
                    quarter = 1;
                else
                    quarter = 4;
            else
            {
                if (y > 0)
                    quarter = 2;
                else
                    quarter = 3;
            }
            Console.WriteLine($"Quarter: {quarter}");*/

            /*Task 3*/

            /*Console.WriteLine("Enter three numbers, each on new line;");
           
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            string res = "";
           
            if (a>b)
                if (a>c)
                    if (b>c)
                        res += ($"{c} {b} {a}"); //cba
                    else //b<c
                        res += ($"{b} {c} {a}"); //bca
                else //a<c
                    res += ($"{b} {a} {c}"); //bac
            else //b>a
                if (b>c)
                    if (c>a)
                        res += ($"{a} {c} {b}"); //acb
                    else //c<a
                        res += ($"{c} {a} {b}"); //cab
                else //b<c
                    res += ($"{a} {b} {c}"); //abc

            Console.WriteLine($"Numbers in growth order: {res}");*/

            /*Task 4*/
            /*Console.WriteLine("Enter a b c, each on new line;");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            //ax^2+bx+c=0;
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
            else if (d == 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1 = {x1}");
            }
            else
                Console.WriteLine("Корней нет");*/

            /*Task 5*/

            Console.WriteLine("Enter any number");

            string number = Console.ReadLine();

            string result = "";
           
            if (Convert.ToInt32(number) <= -10)
            {
                result += "минус ";
              
            }
                
            number = number.Substring(1, 2);

            string dozens = number.Substring(0, 1);
            string units = number.Substring(1, 1);
            if (number == "10")
            {
                result += "десять";
                Console.WriteLine(result);
                return;
            }
           
          
            if (dozens == "1")
            {
                switch (units)
                {
                    case "1":
                        result += "один";
                        break;
                    case "2":
                        result += "две";
                        break;
                    case "3":
                        result += "три";
                        break;
                    case "4":
                        result += "четыр";
                        break;
                    case "5":
                        result += "пят";
                        break;
                    case "6":
                        result += "шест";
                        break;
                    case "7":
                        result += "сем";
                        break;
                    case "8":
                        result += "восем";
                        break;
                    case "9":
                        result += "девят";
                        break;

                }
                result += "надцать";

            }
            else
            {
                switch (dozens)
                {
                    case "2":
                        result += "двацдать ";
                        break;
                    case "3":
                        result += "тридцать ";
                        break;
                    case "4":
                        result += "сорок ";
                        break;
                    case "5":
                        result += "пятьдесят ";
                        break;
                    case "6":
                        result += "шестьдесят ";
                        break;
                    case "7":
                        result += "седьдесят ";
                        break;
                    case "8":
                        result += "восемьдесят ";
                        break;
                    case "9":
                        result += "девяносто ";
                        break;
                }
                switch (units)
                {
                    case "1":
                        result += "один ";
                        break;
                    case "2":
                        result += "два ";
                        break;
                    case "3":
                        result += "три ";
                        break;
                    case "4":
                        result += "четыре ";
                        break;
                    case "5":
                        result += "пять ";
                        break;
                    case "6":
                        result += "шесть ";
                        break;
                    case "7":
                        result += "семь ";
                        break;
                    case "8":
                        result += "восемь ";
                        break;
                    case "9":
                        result += "девять ";
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
