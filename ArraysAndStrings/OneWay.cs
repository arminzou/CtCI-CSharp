using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // One Away: There are three types of edits that can be performed on strings: insert a character,
    // remove a character, or replace a character.Given two strings, write a function to check if they are
    // one edit (or zero edits) away.
    public static class OneWay
    {
        public static bool OneEditAway(string first, string second)
        {
            // Length check
            if (Math.Abs(first.Length - second.Length) > 1) return false;

            // get shorter and longer string
            var s1 = first.Length > second.Length ? second : first;
            var s2 = first.Length > second.Length ? first : second;

            int index1 = 0;
            int index2 = 0;
            bool foundDifference = false;
            while(index1 < s1.Length && index2 < s2.Length)
            {
                if(s1[index1] != s2[index2])
                {
                    if (foundDifference) return false;
                    foundDifference = true;

                    if (s1.Length == s2.Length) index1++; // On replace, move s1 pointer 
                }
                else
                {
                    index1++;
                }
                index2++;
            }
            return true;
        }
    }
}
