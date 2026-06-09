namespace StringToInteger;

record TestCase(string Input, int Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new("42", 42),
            new("   -42", -42),
            new("4193 with words", 4193),
            new("words and 987", 0),
            new("-91283472332", int.MinValue),
            new("91283472332", int.MaxValue),
            new("+1", 1),
            new("00000-42a1234", 0),
            new("   +0 123", 0),
            new("", 0),
            new("   ", 0),
            new("+-12", 0),
            new("2147483647", int.MaxValue),
            new("2147483648", int.MaxValue),
            new("-2147483648", int.MinValue),
            new("-2147483649", int.MinValue),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.MyAtoi(tests[i].Input);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
            {
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            }
            else
            {
                Console.WriteLine("PASS");
            }
        }
    }
}
