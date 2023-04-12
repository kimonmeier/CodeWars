using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSuite
{
    internal class CodeWarsSolution
    {

        public static string StripComments(string text, string[] commentSymbols)
        {
            string[] lines = text.Split('\n');
            StringBuilder outputString = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (outputString.Length != 0)
                {
                    outputString.Append('\n');
                }

                int firstCommentIndex = line.IndexOfAny(commentSymbols.Select(x => x.First()).ToArray());
                if (firstCommentIndex != -1)
                {
                    line = line.Substring(0, firstCommentIndex).TrimEnd();
                }
                outputString.Append(line);
            }

            return outputString.ToString();
            /*
             * Versuch 2 - NOCH SCHLIMMER
             * StringBuilder stringBuilder = new StringBuilder();
            string[] splittedText = text.Split(commentSymbols, StringSplitOptions.TrimEntries);

            foreach (string line in splittedText)
            {
                if(splittedText.Last() == line)
                {
                    continue;
                }

                int firstNewLineIndex = line.IndexOf('\n');
                if(firstNewLineIndex == -1)
                {
                    stringBuilder.Append(line);
                    continue;
                }

                stringBuilder.Append(line.Substring(firstNewLineIndex, line.Length - firstNewLineIndex));
            }

            return stringBuilder.ToString();*/
        }
    }
}
