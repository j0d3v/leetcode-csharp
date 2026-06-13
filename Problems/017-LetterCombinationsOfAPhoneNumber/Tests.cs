using System;
using System.Linq;

namespace LetterCombinationsOfAPhoneNumber;

record TestCase(string Input, string[] Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new("23", ["ad","ae","af","bd","be","bf","cd","ce","cf"]),
            new("", []),
            new("2", ["a","b","c"]),
            new("7", ["p","q","r","s"]),
            new("34",["dg","dh","di","eg","eh","ei","fg","fh","fi"])
        ];

        Solution s = new();

        for (int i = 0; i < tests.Length; i++)
        {
            var got = s.LetterCombinations(tests[i].Input);

            Console.Write($"#{i} => ");

            if (!Equal(got, tests[i].Expected))
            {
                Console.WriteLine(
                    $"FAIL: expected [{string.Join(", ", tests[i].Expected)}], got [{string.Join(", ", got)}]"
                );
            }
            else
            {
                Console.WriteLine("PASS");
            }
        }
    }

    static bool Equal(IList<string> actual, string[] expected)
    {
        return new HashSet<string>(actual)
            .SetEquals(expected);
    }
}
