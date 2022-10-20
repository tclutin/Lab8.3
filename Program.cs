using System.Collections.Generic;
using System.Linq;
using System;

namespace lab_8._3
{
    class Program
    {
        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public static void Main(string[] args)
        {
            List<string> words = new List<string>() { "code", "doce", "ecod", "framer", "frame" };
            List<string> newWords = new List<string>() { };

            for (int i = 0; i < words.Count - 1; i++)
            {
                var firstString = SortString(words[i]);
                var secondString = SortString(words[i + 1]);

                if (firstString == secondString)
                {
                    newWords.Add(words[i + 1]);
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < newWords.Count; j++)
                {
                    if (newWords[j] == words[i])
                    {
                        words.Remove(newWords[j]);
                    }
                }
            }
            words.ForEach(Console.WriteLine);
        }
    }
}