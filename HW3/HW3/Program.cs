using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("In some tasks migh be problems with regional difference '.' or ',' in numbers. The developer yet does not know how to fix it");
            //Task1();

            //Task2();

            //Task3();

            //Task4();

            //Task5();

            //Task6();

            //Task7();

            //Task8();

            //Task9();

            Task10();

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
            Console.WriteLine("Enter natural number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intNumber))
            {
                if (intNumber < 0)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                Console.WriteLine($"Sqrt({intNumber}) = {Sqrt(intNumber)}");

            }
            else
                Console.WriteLine("Incorrect input");
         
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

        public static void Task4()
        {
            Console.WriteLine("Enter natural number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intNumber))
            {
                if (intNumber < 0)
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }

                Console.WriteLine($"{intNumber}! = {Factorial(intNumber)}");

            }
            else
                Console.WriteLine("Incorrect input");

        }

        static int Factorial(int n) 
        {
            int res = 1;
            int temp = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
                temp++;
            }
            return res;
        }

        public static void Task5()
        {
            Console.WriteLine("Enter any number:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {              
                if (int.TryParse(number.ToString().Replace(",","").Replace(".",""), out int intNumber))
                {
                    if (intNumber < 0)
                        intNumber *= -1;
                    Console.WriteLine($"Sum of digits of {number} is {SummCifr(intNumber)}");
                }
                else
                    Console.WriteLine("Incorrect input");
            }
            else
                Console.WriteLine("Incorrect input");
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
            //Console.WriteLine(sum);
            return sum;
        }

        public static void Task6()
        {
            Console.WriteLine("Enter any number:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                int pos = number.ToString().IndexOf(","); 
                if (pos==-1)
                    pos = number.ToString().IndexOf(".");
                if (pos!=-1)
                    pos = number.ToString().Length-1 - pos;              
                if (int.TryParse(number.ToString().Replace(",", "").Replace(".", ""), out int intNumber))
                {
                    if (pos!=-1)
                    {
                        int res = Mirror(intNumber);
                        int mod = res.ToString().IndexOf("-") != -1 ? 1 : 0; //Модификатор смещения в зависимости от наличия или отсуствия запятой
                        string resString = res.ToString().Substring(0, pos+mod) +","+ res.ToString().Substring(pos+mod, res.ToString().Length - pos-mod);
                        Console.WriteLine($"Mirror number of {number} is {resString}");
                    }    
                    else
                        Console.WriteLine($"Mirror number of {number} is {Mirror(intNumber)}");
                }
                else
                    Console.WriteLine("Incorrect input");
            }
            else
                Console.WriteLine("Incorrect input");
        }
        public static int Mirror(int number) 
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
                Console.WriteLine($"Numbers {number1} and {number2} {(ContainSameNumbers(int.Parse(number1.ToString().Replace(",","")), int.Parse(number2.ToString().Replace(",", "")))?"contain":"don't contain")} same digits\n");


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

        public static void Task7()
        {
            string[] operations = { "+", "-", "*", "/", "%" };
            do
            {
                Console.WriteLine("Enter any two numbers, one on each line:");

                if (double.TryParse(Console.ReadLine(), out double number1))
                {
                    if (double.TryParse(Console.ReadLine(), out double number2))
                    {
                        Console.WriteLine("Enter operation(supported operations are + - * / %): ");
                        string operation = Console.ReadLine();
                        string exceptionMsg = "";
                        if (!Array.Exists(operations, element => element == operation))
                        {
                            Console.WriteLine("Incorrect input");
                            return;
                        }
                        else
                        {
                            double res = Calculate(number1, number2, operation, out exceptionMsg);
                            if (exceptionMsg == "")
                                Console.WriteLine($"{number1} {operation} {number2} = {res}\n");
                            else
                                Console.WriteLine($"{exceptionMsg}\n");
                        }
                    }
                    else
                        Console.WriteLine("Incorrect input");
                }
                else
                    Console.WriteLine("Incorrect input");
            } while (true);
           
        }
        public static void ParseCalculationInput(string line, out string exceptionMsg)//Оно почти работает, валится на операции -x+-y. Немного допилить осталось
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

            string[] arguments = onlyNumbers.Split(" ");
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
            onlyOperations = RemoveSpace(onlyOperations);
            //Console.WriteLine($"*{onlyOperations}*");
            string[] presentOperations = new string[onlyOperations.Length];
            for (int i=0;i<onlyOperations.Length;i++)
            {
                presentOperations[i] = onlyOperations[i].ToString();
            }
           

            int mod = 0;//Костыль для дальнейшей проверки
            if (presentOperations.Length == arguments.Length && presentOperations[0] == "-")
            {
                arguments[0] = (double.Parse(arguments[0]) * -1).ToString();
                presentOperations[0] = presentOperations[1];
                mod = 1;
            }
            else if (presentOperations.Length-1 == arguments.Length && presentOperations[2] == "-")
            {
                arguments[1] = (double.Parse(arguments[1]) * -1).ToString();   
                mod = 2;
            }

            


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
            //Console.WriteLine(presentOperations.Length+":"+ arguments.Length+":"+mod);
            if (presentOperations.Length!=arguments.Length-1+mod)
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

        public static string RemoveSpace(string line)
        {
            while (line.Contains(" "))
                line = line.Replace(" ", "");
            return line;
        }

        public static void Task9()
        {
            Console.WriteLine("Enter any two numbers, one on each line:");


            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                if (double.TryParse(Console.ReadLine(), out double number2))
                {

                    if (number1>number2)
                    {
                        double temp = number1;
                        number1 = number2;
                        number2 = temp;
                    }

                    int sum = 0;
                    int mod = number1 != (int)number1 ? 1 : 0; //Решает проблему, которая превращает 15,2--> 15 при (int)number1 и за счет этого сбивается на один левая граница
                  

                    for (int i=(int)number1+mod;i<=number2;i++)
                    {                     
                        if (i % 7 == 0)
                            sum += i;
                    }
                    Console.WriteLine($"Sum of all numbers > {number1} and < {number2} which %7==0 is {sum}");
                }
                else
                    Console.WriteLine("Incorrect input");
            }
            else
                Console.WriteLine("Incorrect input");
        }

        public static void Task10()
        {
            Console.WriteLine("Enter number: ");


            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                int i = 0;
                while (i*i<number1)
                {                 
                    i++;
                    
                }
                Console.WriteLine($"The number of positive integers whose square is less than A = {((i-1)<0?0:(i-1))}"); //Исключая ноль
            }
            else
                Console.WriteLine("Incorrect input");
        }
    }
}