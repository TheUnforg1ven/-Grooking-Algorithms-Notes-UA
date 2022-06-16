using System;
using System.Collections.Generic;

namespace BinarySearch01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myArr = new List<int>();
            for (var i = 0; i < 20; i++)
                myArr.Add(i);

            myArr.Sort();

            var founded = BinarySearch(myArr, 12);
            Console.WriteLine($"Found value is: {founded}");
        }

        private static int BinarySearch(IList<int> arr, int value)
        {
            if (arr.Count == 0)
                return default;

            var first = 0;
            var last = arr.Count - 1;

            while (first < last)
            {
                var middle = (first + last) / 2;

                if (value < arr[middle]) 
                    last = middle - 1;
                else if(value > arr[middle])
                    first = middle + 1;
                else
                {
                    value = arr[middle];
                    return value;
                }
            }

            Console.WriteLine($"There are no needed value in current array");
            return default;
        }
    }
}