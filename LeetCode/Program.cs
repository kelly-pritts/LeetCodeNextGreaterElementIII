using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = NextGreaterElement(12);
            int result2 = NextGreaterElement(12534);
        }

        public static int NextGreaterElement(int n)
        {
            int[] arr = ConvertToArray(n);

            bool found = false;
            int i = 0;
            int smallIndex = -1;
            for (i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i - 1] < arr[i])
                {
                    smallIndex = i - 1;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return -1;
            }

            int smallValue = arr[smallIndex];
            int j = 0;
            int bigIndex = 0;
            int bigValue = 0;
            for (j = arr.Length-1; j > smallIndex; j--)
            {
                if (arr[j] > smallValue)
                {
                    bigIndex = j;
                    bigValue = arr[j];
                    break;
                }
            }

            //swap
            arr[smallIndex] = bigValue;
            arr[bigIndex] = smallValue;

            int length = arr.Length - smallIndex - 1;
            Array.Sort(arr, smallIndex+1,length);

            List<string> strings = arr.ToList().ConvertAll<string>(x => x.ToString());
            string singleString = String.Join("", strings);

            int finalNumber = -1;

            try
            {
                finalNumber = Convert.ToInt32(singleString);
            }
            catch { }

            return finalNumber;


    }

        public static string CreateFinalAnswer(int[] arr)
        {
            List<string> strings = arr.ToList().ConvertAll<string>(x => x.ToString());
            string singleString = String.Join("", strings);

            //string someString = singleString + "&0po(p";
            var nth = 4; // the nth character you want to replace
            var replaceWith = "_"; // the character you want to replace the nth value
            for (var i = nth - 1; i < strings.Count - 1; i += nth)
            {
                //arr[i] = replaceWith;
            }

            return singleString;

        }

        public static int[] ConvertToArray(int n)
        {
            List<int> listOfInts = new List<int>();
            while (n > 0)
            {
                listOfInts.Add(n % 10);
                n = n / 10;
            }
            listOfInts.Reverse();
            int[] ar = listOfInts.ToArray();

            return ar;
        }
    }

   
}



