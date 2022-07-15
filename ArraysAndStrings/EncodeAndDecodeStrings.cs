using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class EncodeAndDecodeStrings
    {
        /*
         * @param strs: a list of strings
         * @return: encodes a list of strings to a single string.
         */
        public String Encode(List<String> strs)
        {
            StringBuilder encodeStr = new StringBuilder();
            foreach (var str in strs)
            {
                int strLength = str.Length;
                encodeStr.Append(strLength + '#');
                encodeStr.Append(str);
            }
            return encodeStr.ToString();
        }

        /*
         * @param str: A string
         * @return: dcodes a single string to a list of strings
         */
        public List<string> Decode(String str)
        {
            List<string> decodedStrs = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                string wordLength = "";
                string word = "";
                while (str[i] != '#')
                {
                    wordLength += str[i];
                    i++;
                }

                int length = int.Parse(wordLength);
                i++;
                for (int j = i; j < length; j++)
                {
                    word += str[j];
                }
                decodedStrs.Add(word);
                i += length - 1;
            }

            return decodedStrs;
        }
    }

}
