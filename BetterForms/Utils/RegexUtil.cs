using System;
using System.Text.RegularExpressions;

namespace BetterForms.Utils
{
    public static class RegexUtil
    {
        public static Regex ValidEmailAddress()
        {
            return new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        public static Regex MinLength(int length)
        {
            return new Regex(@"(\s*(\S)\s*){" + length + @",}");
        }

        public static Regex ValidZipCode()
        {
            return new Regex(@"^\d{5}(?:[-\s]\d{4})?$");
        }
    }
}

