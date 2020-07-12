using System;
using System.Collections.Generic;
using System.Linq;

namespace Technical_Test_Gerardo
{
    class SortingSquare
    {
        static void Main(string[] args)
        {

            var arrayAscending = SortingSquares(new int[] { -1, 0, 2 });
            string array = string.Join(",", arrayAscending);
            Console.Write(array);
            Console.ReadLine();
        }



        public static int[] SortingSquares(int[] arrayNumbers)
        {
            List<int> arrayNumbersFinal = new List<int>();
            foreach (var num in arrayNumbers)
            {
                var square = Convert.ToInt32(Math.Pow(num, 2));
                arrayNumbersFinal.Add(square);
            }
            return arrayNumbersFinal.OrderBy(number => number).ToArray();
        }
    }
}
