using ctci.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // String Compression: Implement a method to perform basic string compression using the counts
    // of repeated characters.For example, the string aabcccccaaa would become a2blc5a3.If the
    // "compressed" string would not become smaller than the original string, your method should return
    // the original string. You can assume the string has only uppercase and lowercase letters (a - z).
    public class StringCompression : Question
    {
        // Straightforward approach but slow
        // Time: O(s + k^2) where s is the length of the string and k is the number of character sequences
        // string concatenation operates in O(n^2) time.

        public string CompressedStr(string str)
        {
            string compressedString = "";
            int count = 0;

            // loop through the string
            for (int i = 0; i < str.Length; i++)
            {
                count++;
                // if next character is not the same or reaches the last character, append count to str and reset count
                if (i + 1 >= str.Length || str[i + 1] != str[i])
                {
                    compressedString += str[i] + count.ToString();
                    count = 0;
                }
            }
            return compressedString.Length < str.Length ? compressedString : str;
        }

        // We can improve it by using StringBuilder
        public static string CompressedStr1(string str)
        {
            StringBuilder compressedString = new StringBuilder();
            int count = 0;

            // loop through the string
            for (int i = 0; i < str.Length; i++)
            {
                count++;
                // if next character is not the same or reaches the last character, append count to str and reset count
                if (i + 1 >= str.Length || str[i + 1] != str[i])
                {
                    compressedString.Append(str[i]);
                    compressedString.Append(count);
                    count = 0;
                }
            }
            return compressedString.Length < str.Length ? compressedString.ToString() : str;
        }

        // We may also check str length in advance.
        public static string CompressedStr2(string str)
        {
            int compressedStrLength = CountCompressedStrLength(str);
            if (compressedStrLength >= str.Length) return str;

            int count = 0;
            StringBuilder compressedString = new StringBuilder(compressedStrLength);

            for(int i = 0; i < str.Length; i++)
            {
                count++;
                if (i + 1 >= str.Length || str[i + 1] != str[i])
                {
                    compressedString.Append(str[i]);
                    compressedString.Append(count);
                    count = 0;
                }
            }
            return compressedString.ToString();
        }

        private static int CountCompressedStrLength(string str)
        {
            int count = 0;
            int length = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count++;
                if (i + 1 >= str.Length || str[i + 1] != str[i])
                {
                    // add number of count in string
                    length += 1 + count.ToString().Length;
                    count = 0;
                }
            }
            return length;
        }

        public override void Run()
        {
            const string original = "abbccccccde";
            var compressed = CompressedStr2(original);
            Console.WriteLine("Original  : {0}", original);
            Console.WriteLine("Compressed: {0}", compressed);
        }
    }
}
