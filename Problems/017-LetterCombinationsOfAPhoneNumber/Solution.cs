using System.Text;

namespace LetterCombinationsOfAPhoneNumber;

public class Solution
{
    private static readonly string[] map =
    [
        "", "", "abc", "def", "ghi", "jkl",
        "mno", "pqrs", "tuv", "wxyz"
    ];

    private readonly List<string> result = [];

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
            return [];

        result.Clear(); // needed for unit testing

        Backtrack(digits, 0, new StringBuilder());

        return result;
    }

    private void Backtrack(string digits, int index, StringBuilder path)
    {
        if (index == digits.Length)
        {
            result.Add(path.ToString());
            return;
        }

        string letters = map[digits[index] - '0'];

        foreach (char c in letters)
        {
            path.Append(c);
            Backtrack(digits, index + 1, path);
            path.Length--;
        }
    }
}
