namespace LongestSubstring;

record TestCase(string Input, int Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new("", 0),
            new("a", 1),
            new("abba", 2),
            new("dvdf", 3),
            new("tmmzuxt", 5),
            new("anviaj", 5),
            new("abcdef", 6),
            new("abababab", 2),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.LengthOfLongestSubstring(tests[i].Input);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
            {
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, " + $"got {got}");
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
    }
}
