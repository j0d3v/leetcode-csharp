namespace RegularExpressionMatching;

record TestCase(string Input, string Pattern, bool Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new("aa", "a", false),
            new("aa", "aa", true),
            new("ab", "a.", true),
            new("aaa", "a*", true),
            new("b", "a*b", true),
            new("abcd", ".*", true),
            new("", "a*", true),
            new("", "a", false),
            new("aab", "c*a*b", true),
            new("mississippi", "mis*is*p*.", false),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.IsMatch(tests[i].Input, tests[i].Pattern);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            else
                Console.WriteLine("PASS");
        }
    }
}
