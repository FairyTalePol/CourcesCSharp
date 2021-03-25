using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter two numbers, each on new line;");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double result = a > b ? a + b : a < b ? a - b : a * b;
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();*/

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

            Console.WriteLine("Enter three numbers, each on new line;");
           
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

            Console.WriteLine($"Numbers in growth order: {res}");
        }
    }
}
