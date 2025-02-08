using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSuite;

internal class CodeWarsSolution
{
    public static string ToUnderscore(int str)
    {
        return Convert.ToString(str);
    }

    public static string ToUnderscore(string str)
    {
        char[] chars = str.ToString().ToCharArray();
        StringBuilder builder = new StringBuilder();


        for (int i = 0; i < chars.Length; i++)
        {
            char currentChar = chars[i];
            if (char.IsUpper(currentChar))
            {
                if (i != 0)
                {
                    builder.Append('_');
                }
                builder.Append(char.ToLower(currentChar));
            } else
            {
                builder.Append(currentChar);
            }

        }

        return builder.ToString();
    }
}
