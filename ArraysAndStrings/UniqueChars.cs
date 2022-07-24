using ctci.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
    public class UniqueChars : Question
    {
        public static bool IsUniqueChars(string str)
        {
            if (str.Length > 256) return false;

            bool[] array = new bool[256];
            foreach (char value in str)
            {
                if (array[value])
                    return false;
                else
                    array[value] = true;
            }
            return true;
        }

        public override void Run()
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + IsUniqueChars(word) + " " + IsUniqueChars(word));
            }
        }
    }
}
