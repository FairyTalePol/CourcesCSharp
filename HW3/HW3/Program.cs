using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            Console.WriteLine(Sqrt(16));
            Console.WriteLine(Sqrt(17));
            Console.WriteLine(Sqrt(18));
            Console.WriteLine(Sqrt(19));
            Console.WriteLine(Sqrt(20));
            Console.WriteLine(Sqrt(21));
            Console.WriteLine(Sqrt(22));
            Console.WriteLine(Sqrt(23));
            Console.WriteLine(Sqrt(24));
            Console.WriteLine(Sqrt(25));

            //Console.WriteLine(Factorial(6));

            //SummCifr(553); //Добавить ограничение на количество символов

            //Console.WriteLine(CountNumbers(123));

            //Console.WriteLine(Mirror(-1423523));

            //ProceedCalculations();

            //Task8();

            Console.ReadKey();
        }

        static void Task1()
        {
            int counter = 0;
            int sum = 0;
            for (int i = 2; i < 100; i += 2)
            {
                sum += i;
                counter++;
                //Console.WriteLine($"i={i}; counter={counter}; sum = {sum}");
            }
            Console.WriteLine($"Summ of odd number = {sum}, amount of odd numbers = {counter}");
        }

        public static void Task2()
        {
            Console.WriteLine("Enter positive number (>0):");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double doubleNumber))
            {
                if (!int.TryParse(input, out int intNumber))
                {
                    Console.WriteLine("Only integer numbers can be prime");
                    return;
                }
                Console.WriteLine($"Number {input} is {(Prime(intNumber)?"":"not")} prime");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        static bool Prime(int number)
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

        public static void Task3()
        {

        }
        static int Sqrt(int number)
        {

            for (int i = 0; i <= number / 2 + 1; i++)
            {
                if (i * i > number)
                {
                    return Math.Abs(number - i * i) < Math.Abs(number - ((i - 1) * (i - 1)) )? i : i - 1;
                }                
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
            bool minus = false;
            if (number<0)
            {
                number *= -1;
                minus = true;
            }    
            int mirror = 0;
            int count = CountNumbers(number);
            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine($"i = {i}; number = {number}; number%10 = {number%10}");
                mirror += MultiplyBy10(number % 10, count - i - 1);
                number = number / 10;
                //Console.WriteLine($"Mirror = {mirror}; number = {number}");
            }
            return !minus?mirror:mirror*-1;
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

        public static void Task8()
        {
            do
            {
                Console.WriteLine("Please enter two numbers, one on each line");

                string exceptionMsg = "Unsupported argument. Please use numbers";

                if (!double.TryParse(Console.ReadLine(), out double number1))
                {
                    Console.WriteLine(exceptionMsg);
                    continue;
                }
                if (!double.TryParse(Console.ReadLine(), out double number2))
                {
                    Console.WriteLine(exceptionMsg);
                    continue;
                }

                if (number1 < 0)
                    number1 *= -1;
                if (number2 < 0)
                    number2 *= -1;
                Console.WriteLine(ContainSameNumbers(int.Parse(number1.ToString().Replace(",","")), int.Parse(number2.ToString().Replace(",", "")))+"\n");


                /*Альтернативный способ избавления от запятой*/

                //while (!int.TryParse(number1.ToString(), out int temp1))
                //{
                //    number1 *= 10;
                //}
                //while (!int.TryParse(number2.ToString(), out int temp2))
                //{
                //    number2 *= 10;
                //}
               
                //Console.WriteLine(ContainSameNumbers(Convert.ToInt32(number1),Convert.ToInt32(number2)) + "\n");
                
                /*Конец альтернативного способа*/

            } while (true);
           
        }

        public static bool ContainSameNumbers(int a, int b)
        {
            int tempB = b;
            while(a>0)
            {
                tempB = b;
                while (tempB > 0)
                {
                    
                    if (a % 10 == tempB% 10)
                        return true;
                    tempB /= 10;
                }
                a /= 10;
               
            }
            return false;
        }

        public static void ProceedCalculations()
        {
            string exceptionMsg;
            do
            {
                Console.WriteLine("Type calculation input (one line):");
                exceptionMsg = "";
                ParseCalculationInput(Console.ReadLine(),out exceptionMsg);
                if (exceptionMsg != "")
                    Console.WriteLine(exceptionMsg);
            } while (true);
        }
        public static void ParseCalculationInput(string line, out string exceptionMsg)//Первые два встретившихся в строке аргумента и первая встретившаяся операция
        {
            while (line.Contains("."))
                line = line.Replace(".", ",");
            line = line.Trim();
            line = RemoveMultiplySpace(line);

            string[] operations = { "+", "-", "*", "/", "%" };

            string onlyNumbers = line;
            foreach (string o in operations)
            {
                onlyNumbers = onlyNumbers.Replace(o, " ");
            }
            onlyNumbers = onlyNumbers.Trim();
            onlyNumbers = RemoveMultiplySpace(onlyNumbers);
            //Console.WriteLine(onlyNumbers);//только аргументы, разделенные пробелом

            string[] arguments = onlyNumbers.Split(' ');
            if (arguments.Length < 2 || !double.TryParse(arguments[0], out double firstArgument) || !double.TryParse(arguments[1], out double secondArgument))
            {
                exceptionMsg="Invalid input, not enough arguments";
                return;
            }

            string onlyOperations = line;
            for (int i = 0; i < 10; i++)
            {
                while(onlyOperations.Contains(i.ToString()))
                    onlyOperations = onlyOperations.Replace(i.ToString(), " ");
            }
            while (onlyOperations.Contains(","))
                onlyOperations = onlyOperations.Replace(",", "");

            onlyOperations = onlyOperations.Trim();
            onlyOperations = RemoveMultiplySpace(onlyOperations);
            //Console.WriteLine($"{onlyOperations}");
            string[] presentOperations = onlyOperations.Split(' ');

            if (presentOperations.Length<1 || presentOperations[0]=="")
            {
                exceptionMsg = "Invalid input, not enough operations";
                return;
            }
            foreach(string o in presentOperations)
            {
                if (!Array.Exists(operations, element => element == o)){
                    exceptionMsg = "Invalid input, unsupported operation";
                    return;
                }
            }
            if (presentOperations.Length!=arguments.Length-1)
            {
                exceptionMsg = "Invalid input, too many arguments or too many operations";
                return;
            }

            //Console.WriteLine(onlyOperations);//только аргументы, разделенные пробелом
            string exceptionCalculation;
            double result = Calculate(double.Parse(arguments[0]), double.Parse(arguments[1]), presentOperations[0], out exceptionCalculation);

            if (exceptionCalculation == "")
                Console.WriteLine($"{arguments[0]} {presentOperations[0]} {arguments[1]} = {result}\n");
            else
                Console.WriteLine(exceptionCalculation);
            
            exceptionMsg = "";
           
        }
        public static double Calculate(double a, double b, string operation, out string exceptionCalculation)
        {
            exceptionCalculation = "";
            if ((operation == "/" || operation == "%")&&b==0)
            {
                exceptionCalculation = "Can't divide by zero";
                return Int32.MinValue;
            }
                
            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                case "%":
                    return a % b;

            }
            Console.WriteLine("Unknown exception");
            return Int32.MinValue;
        }

        public static string RemoveMultiplySpace(string line)
        {
            while (line.Contains("  "))
                line = line.Replace("  ", " ");
            return line;
        }
    }
}