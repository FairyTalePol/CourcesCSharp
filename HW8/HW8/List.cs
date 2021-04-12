using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    public class List
    {
        static int _baseSize = 5;
        double[] _array = new double[_baseSize];


        public bool Add(double val, int pos)
        {
            return true;
        }

        public bool Add(double val)
        {
            return true;
        }

        public bool Remove(int pos)
        {
            return true;
        }

        public double[] Sort(double[] arr, bool asc = true)
        {           
            int imin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                imin = MaxValuePos(arr, i);
                double temp = arr[i];
                arr[i] = arr[imin];
                arr[imin] = temp;
            }
            return arr;      
        }

        static int MaxValuePos(double[] arr, int startIndex)
        {
            double max = arr[startIndex];
            int imax = startIndex;
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    imax = i;
                }
            }
            return imax;
        }

    }
}

