using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSuite
{
    internal class CodeWarsSolution
    {
        public static string Add(string a, string b)
        {
            StringBuilder builder = new StringBuilder();

            char[] numbersA = a.Reverse().ToArray();
            char[] numbersB = b.Reverse().ToArray();

            int rest = 0;
            for (int i = 0; i < int.Max(a.Length, b.Length); i++)
            {
                int number1 = numbersA.Length > i ? int.Parse(new[] { numbersA[i] }) : 0;
                int number2 = numbersB.Length > i ? int.Parse(new[] { numbersB[i] }) : 0;

                builder.Append(CodeWarsSolution.Add(number1, number2, rest, out rest));
            }

            if(rest != 0)
            {
                builder.Append(rest);
            }

            return new string(builder.ToString().Reverse().ToArray());
        }

        public static int Add(int a, int b, int restVonVorher, out int rest) {
            rest = 0;
            if(a + b + restVonVorher < 10)
            {
                return a + b + restVonVorher;
            } else
            {
                rest = 1;

                return a + b + restVonVorher - 10;
            }
        }
    }
}
