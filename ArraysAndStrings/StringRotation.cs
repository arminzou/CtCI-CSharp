using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    // String Rotation:Assumeyou have a method isSubstringwhich checks if one word is a substring
    // of another.Given two strings, sl and s2, write code to check if s2 is a rotation of sl using only one
    // call to isSubstring(e.g., "waterbottle" is a rotation of"erbottlewat").
    public class StringRotation
    {
        public static bool IsSubstring(string big, string small)
        {
            return big.IndexOf(small) >= 0;
        }

        public static bool IsRotation(string s1, string s2)
        {
            if(s1.Length == s2.Length && s1.Length > 0)
            {
                string s1s1 = s1 + s1;
                return IsSubstring(s1s1, s2);
            }
            return false;
        }
    }
}
