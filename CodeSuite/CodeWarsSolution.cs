using System.Collections.Generic;
using System.Linq;

namespace CodeSuite;

public sealed class CodeWarsSolution
{
    public static bool Scramble(string str1, string str2)
    {
        List<char> scrambledCharacters = str1.ToCharArray().ToList();
        char[] charactersToFind = str2.ToCharArray();

        for (int i = 0; i < charactersToFind.Length; i++)
        {
            char characterToFind = charactersToFind[i];

            char foundCharacter = scrambledCharacters.FirstOrDefault(x => x == characterToFind);

            if (foundCharacter == default(char))
            {
                return false;
            }

            scrambledCharacters.Remove(foundCharacter);
        }

        return true;
    }
}
