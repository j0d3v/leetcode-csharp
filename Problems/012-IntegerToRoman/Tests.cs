using System;

namespace IntegerToRoman;

record TestCase(int Input, string Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        {
            new(1, "I"),
            new(3, "III"),
            new(4, "IV"),
            new(9, "IX"),
            new(58, "LVIII"),
            new(1994, "MCMXCIV"),
            new(3999, "MMMCMXCIX"),
            new(40, "XL"),
            new(90, "XC"),
            new(400, "CD"),
            new(900, "CM"),
        };

        var solution = new Solution();

        for (int i = 0; i < tests.Length; i++)
        {
            var got = solution.IntToRoman(tests[i].Input);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            else
                Console.WriteLine("PASS");
        }
    }
}
