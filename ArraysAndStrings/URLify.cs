using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // URLify: Write a method to replace all spaces in a string with '%20'. You may assume that the string
    // has sufficient space at the end to hold the additional characters, and that you are given the "true"
    // length of the string. (Note: If implementing in Java, please use a character array so that you can
    // perform this operation in place.)
    public static class URLify
    {
        public static void ReplaceSpaces(char[] str, int trueLength)
        {
            // count whitespaces
            int numOfSpaces = 0, index, i = 0;
            for (i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    numOfSpaces++;
                }
            }

            // calculate new string length
            index = trueLength + numOfSpaces * 2;

            if (trueLength < str.Length) str[trueLength] = '\0';
            for (i = trueLength - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    // insert %20
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index -= 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index -= 1;
                }
            }
        }
        public static int FindLastCharacter(char[] str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
