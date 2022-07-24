using ctci.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
    public class CheckPermutation : Question
    {
        // Solution #1: Sort the strings
        static string Sort(string s)
        {
            char[] characters = s.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public static bool PermutationBySorting(string s, string t)
        {
            if (s.Length != t.Length) return false;

            return Sort(s).Equals((Sort(t)));
        }

        // Solution #2: Use dictionary
        public static bool PermutationByDictionary(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var charTable = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charTable.ContainsKey(c))
                    charTable[c]++;
                else
                    charTable[c] = 1;
            }

            foreach (char c in t)
            {
                if (charTable.ContainsKey(c))
                {
                    charTable[c]--;
                    if (charTable[c] < 0)
                        return false;
                }
                else return false;
            }
            return true;
        }

        public override void Run()
        {
            string[][] pairs =
            {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},
                new string[]{"hello", "llloh"}
            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result1 = PermutationBySorting(word1, word2);
                var result2 = PermutationByDictionary(word1, word2);
                Console.WriteLine("{0}, {1}: {2} / {3}", word1, word2, result1, result2);
            }
        }
    }
}
