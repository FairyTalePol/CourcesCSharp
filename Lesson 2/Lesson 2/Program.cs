using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //&& - проверяется до момента, пока будет гарантированный результат
            //& - проверяется всё
            //Аналогично для || |

            int a = 3;
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
            Console.ReadKey();


        }
    }
}
