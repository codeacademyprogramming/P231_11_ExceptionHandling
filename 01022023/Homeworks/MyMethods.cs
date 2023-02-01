using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal static  class MyMethods
    {
        public static string ToCapitalize(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string newStr = "";
            newStr += char.ToUpper(value[0]);

            for (int i = 1; i < value.Length; i++)
            {
                newStr += char.ToLower(value[i]);
            }

            return newStr;
        }

        public static int CalcWordsCount(this string value)
        {
            if (value == null)
                return 0;

            var arr = value.Split(' ');
            return arr.Length;
        }

        public static int FindCharCount(this string value, char cr)
        {
            if (value == null)
                return 0;

            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == cr)
                    count++;
            }

            return count;
        }
    }
}
