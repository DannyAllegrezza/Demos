using System;
using System.IO;
using System.Text;
namespace CodeWars._4kyu
{
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            if (String.IsNullOrEmpty(text))
            {
                return "";
            }

            var startingSymbol = char.Parse(commentSymbols[0]);
            var endingSymbol = char.Parse(commentSymbols[1]);
            var result = new StringBuilder();
            var shouldRemoveTillEndOfLine = false;

            using (StringReader reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var lineChars = line.ToCharArray();

                    for (int index = 0; index < lineChars.Length; index++)
                    {
                        char currentChar = lineChars[index];

                        if (currentChar == startingSymbol || currentChar == endingSymbol)
                        {
                            shouldRemoveTillEndOfLine = true;
                            lineChars[index] = ' ';
                        }

                        if (shouldRemoveTillEndOfLine)
                        {
                            lineChars[index] = ' ';
                        }
                    }

                    shouldRemoveTillEndOfLine = false;
                    var strippedLine = new string(lineChars);

                    result.Append(strippedLine.TrimEnd());
                    result.Append("\n");
                }
            }

            return result.ToString().Trim();
        }
    }
}
