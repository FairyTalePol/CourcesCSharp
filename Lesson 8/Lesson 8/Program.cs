using System;

namespace Lesson_8
{
    class Program
    {

        enum Ecolprpoint
        {
            Red,
            Green,
            Blue
        }

        class Point
        {
            private int _x;
            private int _y;
            private Ecolprpoint _color;

            public string toString()
            {
                return "Gay";
            }

            public Point(int x, int y, Ecolprpoint color)
            {
                _x = x;
                _y = y;
                _color = color;
            }

            public int GetX()
            {
                return _x;
            }

            public int GetY()
            {
                return _x;
            }


        }

        static void Main(string[] args)
        {
            /*var car = new Car(true);
            car.Drive();*/
            int number = 5;
            Method1(ref number);
            Console.WriteLine(number);

            int res = 0;
            Method1(ref number,out res);
            Console.WriteLine($"{number} {res}");

            var rez=Method4();
            Console.WriteLine(rez.Item1);
            Console.WriteLine(rez.Item2);

        }

        private static void Method1(ref int number,out int res)
        {
            res = 99;
            number += 10;
        }
        private static void Method1 (ref int number)
        {
            number += 10;
        }

        private static void Method1 (int number)
        {
            number += 10;
        }

        private static (int,int) Method4()
        {
            return (5, 6);
        }
    }
}
