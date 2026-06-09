using System;

namespace PalindromeNumber;

record TestCase(int Input, bool Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new(121, true),
            new(-121, false),
            new(10, false),
            new(0, true),
            new(1, true),
            new(1221, true),
            new(1231, false),
            new(12321, true),
            new(1001, true),
            new(1000021, false),
            new(int.MaxValue, false),
            new(int.MinValue, false),
            new(11, true),
            new(22, true),
            new(1234321, true),
            new(123456, false),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.IsPalindrome(tests[i].Input);

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
