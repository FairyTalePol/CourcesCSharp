using System;

namespace HW_6
{
    class Program
    {
        static string[,] baseNumbers = new string[10, 2] { {"one", "1"},
                { "two", "2" },
                { "three", "3" },
                { "four", "4" },
                { "five", "5" },
                { "six", "6" },
                { "seven", "7" },
                { "eight", "8" },
                { "nine", "9" },
                { "zero", "0" } };

        static string hundred = "hundred";

        static void Main(string[] args)
        {
            
           
            string error = "";
            string res = SplitNumber(Console.ReadLine(), out error);

           
            


        }

        static string SplitNumber(string line, out string errorMsg)
        {
            errorMsg = "";
            line = line.Trim();
            string[] split = line.Split(" ");
            string result = "";
            string firstNum = GetFromArray(baseNumbers, split[0]);
            Console.WriteLine(line.Split(hundred).Length);
            if (line.Split(hundred).Length >1 && line.Split(hundred)[1].Equals(""))
            {
                Console.WriteLine(firstNum + "00");
                return firstNum + "00";               
            }
            else if (line.Split(hundred).Length == 1)
            {
                errorMsg = "Incorrect input";
                return null;
            }

            string rightPart = line.Split(hundred)[1]; //часть после hundred





            return "-1";
        }

        static string GetFromArray(string[,] arr, string key)
        {
            for (int i=0;i<arr.GetLength(0);i++)
            {
                if (arr[i, 0].Equals(key))
                    return arr[i, 1];
            }
            return null;
        }
    }
}
