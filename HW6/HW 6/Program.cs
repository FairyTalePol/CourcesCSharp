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
                { "", "0" } };

        static string[,] teenNumbers = new string[6, 2] { {"eleven", "11"},
                { "twelve", "12" },
                { "thirteen", "13" },
                { "fifteen", "15" },
                {"ten","10" },
                {"eighteen","18" }
              };

        static string[,] tyNumbers = new string[4, 2] { {"twenty", "2"},
                { "thirty", "3" },
                { "fifty", "5" },
                {"eighty","8" }
              };

        static string[] errors = new string[4] 
            {   "Incorrect input, unspecified",
                "Incorrect input, unknown construction near '-'",
                "Incorrect input, error after 'hundred'",
                "" };

        static string hundred = "hundred";

        static void Main(string[] args)
        {
            //Tasks_1_to_5();

            //Task7();

            Task6();

        }

        static void Tasks_1_to_5()
        {
            Console.WriteLine("Type array dimensions, one on each line:");
            int x = 0;
            int y = 0;
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1 || (!int.TryParse(Console.ReadLine(), out y)) ||y<1)
            {
                Console.WriteLine("Wrong input, two positive integers expected");
            }    
            int[,] arr = new int[x, y];
            arr = FillArrayRandom(arr);

            Console.WriteLine(ToString(arr)); 

            int xmin = 0;
            int ymin = 0;
            int xmax = 0;
            int ymax = 0;
            int min = iMin(arr,out xmin,out ymin);
            int max = iMax(arr, out xmax, out ymax);

            Console.WriteLine($"Min value: {min} with position: {xmin}, {ymin}\n");
            Console.WriteLine($"Max value: {max} with position: {xmax}, {ymax}\n");

            int counter = 0;
            Console.WriteLine("Numbers which are bigger than their neighbours: \n");
            for (int i=0; i<arr.GetLength(0);i++)
            {
                for (int j=0; j<arr.GetLength(1);j++)
                {
                    if (CheckNeighbours(arr, i, j))
                    {
                        Console.WriteLine($"{arr[i,j]} on position {i} {j} ");
                        counter++;
                    }
                }
            }
            Console.WriteLine($"\nAmount of such numbers: {counter}");
            // int arr = FillArrayRandom();
        }

        public static bool CheckNeighbours(int[,] arr, int x, int y)
        {
            if (x > 0 && arr[x, y] <= arr[x - 1, y])             
                return false;
            if (x < arr.GetLength(0)-1 && arr[x, y] <= arr[x+1, y])
                return false;
            if (y > 0 && arr[x, y] <= arr[x , y-1])
                return false;
            if (y < arr.GetLength(1) - 1 && arr[x, y] <= arr[x, y+1])
                return false;
            return true;
        }

        static string ToString(int[,] arr)
        {
            string res = "";
            for (int i=0; i<arr.GetLength(0);i++)
            {
                for (int j=0; j<arr.GetLength(1);j++)
                {
                    res+=$"{arr[i,j]}\t";
                }
                res += "\n";
            }
            return res;
        }

        public static int iMin(int[,] arr, out int x, out int y)
        {
            int min = arr[0, 0];
            x= 0;
            y= 0;
            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=0;j<arr.GetLength(0);j++)
                {
                    if (arr[i,j]<min)
                    {
                        min = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return min;
        }

        public static int iMax(int[,] arr, out int x, out int y)
        {
            int max = arr[0, 0];
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }
            return max;
        }

        static int[,] FillArrayRandom(int[,] array)
        {
            Random r = new Random();
            for (int i = 0; i< array.GetLength(0); i++)//в высоту
            {
                for (int j=0;j<array.GetLength(1);j++)
                {
                    array[i, j] = r.Next(0, 100);
                }
            }
            return array;
        }

        static void Task6()
        {
            string error = "";
            string res = "";
            do
            {
                Console.WriteLine("Type number (example: 423):");
                int number;
                while (!int.TryParse(Console.ReadLine(), out number)||number>999)
                {
                    Console.WriteLine("Incorrect input, integer expected (0-999)");
                }
                res = IntToString(number,out error);
                Console.WriteLine($"Result number: {res}\n");
            } while (true);
        }

        static string IntToString(int number, out string error)
        {
            error = "";
            if (number == 0)
                return "zero";
            string sNumber = number.ToString();
           
            string res = "";
            if (sNumber.Length==1)
            {
                if (GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true) != null)
                {
                    res = $"{res}{GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true)}";
                }
            }
            else
            {
                if (sNumber[sNumber.Length-2].ToString()=="1")
                {
                    if (GetFromArray(teenNumbers, sNumber.Substring(sNumber.Length-2,2), true)!=null)
                    {
                        res = $"{res}{GetFromArray(teenNumbers, sNumber.Substring(sNumber.Length - 2, 2), true)}";
                    }
                    else if (GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true) != null)
                    {
                        res = $"{res}{GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true)}teen";
                    }
                    else
                    {
                        error = "Incorrect input";
                        return null;
                    }
                }
                else if (sNumber[sNumber.Length - 2].ToString().Equals("0"))
                {
                    if (GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true) != null)
                    {
                        res = $"{res}{GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true)}";
                    }
                    else
                    {
                        error = "Incorrect input";
                        return null;
                    }
                }
                else
                {
                    if (GetFromArray(tyNumbers, sNumber.Substring(sNumber.Length - 2, 1), true) != null)
                    {
                        res = $"{res}{GetFromArray(tyNumbers, sNumber.Substring(sNumber.Length - 2, 1), true)}";
                    }
                    else if (GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 2, 1), true) != null)
                    {
                        res = $"{res}{GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 2, 1), true)}ty";
                    }
                    else
                    {
                        error = "Incorrect input";
                        return null;
                    }

                    if (sNumber.Substring(sNumber.Length - 1, 1) != "0")
                        res += "-";
                    if (GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true) != null)
                    {
                        res = $"{res}{GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 1, 1), true)}";
                    }
                }    

            }
            if (sNumber.Length>2)
            {
                if (GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 3, 1), true) != null)
                {
                    res = $"{GetFromArray(baseNumbers, sNumber.Substring(sNumber.Length - 3, 1), true)} hundred {res}";
                }
            }

            return res;
        }
        static void Task7()
        {
            string error = "";
            string res = "";
            do {
                Console.WriteLine("Type number from 1 to 999 (example: one hundred seventy-two)");
                res = SplitNumber(Console.ReadLine(), out error);
                while (res == null)
                {
                    Console.WriteLine($"{error}\n");
                    res = SplitNumber(Console.ReadLine(), out error);
                }
                Console.WriteLine($"Result number: {res}\n");
            } while (true);
            
        }

        static string SplitNumber(string line, out string errorMsg)
        {
            errorMsg = "";
            line = line.Trim();
            if (line == "zero")
                return "0";
            string[] split = line.Split(" ");
            string result = "";
            if (line.Contains(hundred))
            {
               
                 result = GetFromArray(baseNumbers, split[0]);
            }
            if (line.Split(hundred)[0].Equals(""))
            {
               
                result = "1";

            }
            //Console.WriteLine(line.Split(hundred).Length);
            if (line.Split(hundred).Length > 1 && line.Split(hundred)[1].Equals(""))
            {
               
                return result + "00";
            }           
        

            string rightPart = line.Split(hundred)[line.Contains(hundred)?1:0].Trim(); //часть после hundred, гарантированно существует
            //Console.WriteLine($"*{rightPart}*");
            if (GetFromArray(baseNumbers, rightPart)!=null) //00(1-9)
            {
               
                result = $"{result}{(line.Contains(hundred)?"0":"")}{GetFromArray(baseNumbers, rightPart)}";
            }
            else if (GetFromArray(teenNumbers, rightPart)!=null) //0(10-19)
            {
             
                result = $"{result}{GetFromArray(teenNumbers, rightPart)}";
            }
            else if (GetFromArray(tyNumbers, rightPart) != null) //0(10-19)
            {               
                result = $"{result}{GetFromArray(tyNumbers, rightPart)}0";              
            }
            else if (GetFromArray(baseNumbers, rightPart.Replace("teen","")) != null) //0(10-19)
            {
               
                result = $"{result}1{GetFromArray(baseNumbers, rightPart.Replace("teen", ""))}";
            }
            else if (GetFromArray(baseNumbers, rightPart.Replace("ty", "")) != null) //0(10-19)
            {
               
                result = $"{result}{GetFromArray(baseNumbers, rightPart.Replace("ty", ""))}0";
            }
            else if (rightPart.Contains("-"))//0(twenty-two)
            {
                if (GetFromArray(tyNumbers, rightPart.Split("-")[0]) != null)
                {
                    result = $"{result}{GetFromArray(tyNumbers, rightPart.Split("-")[0])}";
                }              
                else if (GetFromArray(baseNumbers, rightPart.Split("-")[0].Replace("ty",""))!=null)
                {
                  
                    result = $"{result}{GetFromArray(baseNumbers, rightPart.Split("-")[0].Replace("ty", ""))}";
                }
                else
                {
                    //Console.WriteLine(rightPart.Split("-")[0]);
                    errorMsg = errors[1];
                    return null;
                }

                if (GetFromArray(baseNumbers, rightPart.Split("-")[1]) != null)
                {
                   
                    result = $"{result}{GetFromArray(baseNumbers, rightPart.Split("-")[1])}";
                }
                else
                {
                    errorMsg = errors[1];
                    return null;
                }          
            }           
            else
            {
                errorMsg = errors[2];
                return null;
            }
            return result;
        }

        static string GetFromArray(string[,] arr, string key,  bool rev = true)
        {
            for (int i=0;i<arr.GetLength(0);i++)
            {
                if (!rev)
                {
                    if (arr[i, 0].Equals(key))
                        return arr[i, 1];
                }
                else if (arr[i, 1].Equals(key))
                    return arr[i, 0];

            }
            return null;
        }
    }
}
