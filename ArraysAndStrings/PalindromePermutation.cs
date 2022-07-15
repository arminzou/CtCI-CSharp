using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
    // A palindrome is a word or phrase that is the same forwards and backwards.A permutation
    // is a rearrangement of letters.The palindrome does not need to be limited to just dictionary words.

    public static class PalindromePermutation
    {
        // Solution 1: Use Dictionary to store character frequency and check number of odd counts at the end
        public static bool IsPermutationOfPalindrome(string str)
        {
            // Create dictionary to store character frequency
            var frequecyMap = new Dictionary<char, int>();

            foreach (var c in str.ToCharArray())
            {
                int count;
                var lowerCaseChar = char.ToLower(c);
                if (char.IsLetter(lowerCaseChar))
                {
                    frequecyMap.TryGetValue(lowerCaseChar, out count);
                    if (count == 0)
                        frequecyMap.Add(lowerCaseChar, 1);
                    else
                        frequecyMap[lowerCaseChar]++;
                }
            }

            bool foundOdd = false;
            // check to make sure only one character frequency is odd
            foreach (var c in frequecyMap)
            {
                if (foundOdd)
                {
                    return false;
                }

                if (frequecyMap[c.Key] % 2 == 1)
                {
                    foundOdd = true;
                }
            }
            return true;
        }

        // Solution 2: Since the time complexity can't be furthur improve with O(n), we can improve it by checking the way to check for odd counts
        // use dictionary to store for frequency, check for odd count as we iterate through string
        public static bool IsPermutationOfPalindrome2(string str)
        {
            int oddCount = 0;

            // create a stack to store character frequency
            var frequecyMap = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    int count;
                    char currentChar = char.ToLower(c);
                    if (frequecyMap.TryGetValue(currentChar, out count))
                    {
                        frequecyMap[currentChar] = count;
                        oddCount--;
                    }
                    else
                    {
                        frequecyMap[currentChar] = count + 1;
                        oddCount++;
                    }
                }
            }
            return oddCount <= 1;
        }
    }
}
