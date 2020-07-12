using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Technical_Test_Gerardo
{
    public class WhatsWord
    {
        public bool FindWord(string word, char[,] charWord)
        {
            var response = false;
            var listWords = CreateWords(charWord);
            if (FindWords(listWords, word))
            {
                return response = true;
            }

            return response;
        }

        private bool FindWords(List<string> listWords, string word)
        {
            return listWords.Any(x => x.Contains(word));
        }

        private List<string> CreateWords(char[,] charWord)
        {
            var palabra = new StringBuilder();
            List<string> listOfWords = new List<string>();
            if (charWord.Length > 0)
            {
                for (int i = 0; i < charWord.GetLength(0); i++)
                {
                    for (int j = 0; j < charWord.GetLength(1); j++)
                    {
                        palabra = palabra.Append(charWord[i, j]);
                    }
                    listOfWords.Add(palabra.ToString());
                    palabra = palabra.Clear();
                }
                for (int i = 0; i < charWord.GetLength(0); i++)
                {
                    for (int j = 0; j < charWord.GetLength(1); j++)
                    {
                        palabra = palabra.Append(charWord[j, i]);
                    }
                    listOfWords.Add(palabra.ToString());
                    palabra = palabra.Clear();
                }
            }

            return listOfWords;

        }

    }
}




