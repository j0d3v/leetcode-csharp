namespace LongestPalindromicSubstring;

record TestCase(string Input, string Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new("babad", "bab"),
            new("cbbd", "bb"),
            new("a", "a"),
            new("ac", "a"),
            new("racecar", "racecar"),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new Solution();
            var got = s.LongestPalindrome(tests[i].Input);

            Console.Write($"#{i} => ");

            if (got == tests[i].Expected)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            }
        }
    }
}
