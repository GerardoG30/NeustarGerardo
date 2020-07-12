using System;
using System.Collections.Generic;
using System.Linq;

namespace Technical_Test_Gerardo
{
    class SortingSquare
    {
        static void Main(string[] args)
        {
            //SortingSquares
            var arrayAscending = SortingSquares(new int[] { -1, 0, 2 });
            string array = string.Join(",", arrayAscending);
            Console.WriteLine("SortingSquares Output");
            Console.Write(array);
            //Ascending tree
            var NodeWeight = new int[] { 2, 4, 3 };
            Ascending_Tree tree = new Ascending_Tree();
            for (int i = 0; i < NodeWeight.Length; i++)
            {
                tree.AddNode(NodeWeight[i]);
            }

            tree.PrintNodes();
            Console.WriteLine("Ascending tree Output");
            tree.OrderWeigths();


            //What's Word
            string word = "dog";
            char[,] charWords = new char[,] { { 'x', 'y', 'z' }, { 'd', 'o', 'g' }, { 'a', 'b', 'c' } };
            WhatsWord words = new WhatsWord();
            var response = words.FindWord(word, charWords);
            Console.WriteLine("Whats word Output");
            Console.WriteLine(response);
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
