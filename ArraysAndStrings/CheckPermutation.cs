using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
    public static class CheckPermutation
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
    }
}
