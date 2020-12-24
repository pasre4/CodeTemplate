using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Common
{
    public static class CamelHelper
    {

        private static char SEPARATOR = '_';

        //驼峰转下划线格式
        public static string toUnderlineName(this string s)
        {
            if (s == null)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            bool upperCase = false;
            var charArr = s.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                char c = charArr[i];
                bool nextUpperCase = true;
                if (i < (charArr.Length - 1))
                {
                    nextUpperCase = Char.IsUpper(charArr[i + 1]);
                }
                if ((i >= 0) && Char.IsUpper(c))
                {
                    if (!upperCase || !nextUpperCase)
                    {
                        if (i > 0) sb.Append(SEPARATOR);
                    }
                    upperCase = true;
                }
                else
                {
                    upperCase = false;
                }

                sb.Append(Char.ToLower(c));
            }

            return sb.ToString();
        }

        //下划线转驼峰格式
        public static string toCamelCase(this string s)
        {
            if (s == null)
            {
                return null;
            }
            s = s.ToLower();
            StringBuilder sb = new StringBuilder();
            bool upperCase = false;
            var charArr = s.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                char c = charArr[i];
                if (c == SEPARATOR)
                {
                    upperCase = true;
                }
                else if (upperCase)
                {
                    sb.Append(Char.ToUpper(c));
                    upperCase = false;
                }
                else if (i == 0)
                {
                    //如果需要驼峰形式首字母大写请放开
                    sb.Append(Char.ToUpper(c));
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }


    }
}
