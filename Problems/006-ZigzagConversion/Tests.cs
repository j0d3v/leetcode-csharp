namespace ZigzagConversion;

record TestCase(string S, int NumRows, string Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR"),
            new("PAYPALISHIRING", 4, "PINALSIGYAHRPI"),
            // Edge cases
            new("A", 1, "A"),
            new("AB", 1, "AB"),
            new("ABC", 4, "ABC"),
            // Small cases
            new("ABC", 2, "ACB"),
            new("ABCDE", 2, "ACEBD"),
            // Middle-row behavior
            new("ABCDE", 3, "AEBDC"),
            new("ABCDEFGHI", 3, "AEIBDFHCG"),
            // Larger 4-row case
            new("ABCDEFGHIJK", 4, "AGBFHCEIKDJ"),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.Convert(tests[i].S, tests[i].NumRows);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
            {
                Console.WriteLine($"FAIL: expected \"{tests[i].Expected}\", " + $"got \"{got}\"");
            }
            else
            {
                Console.WriteLine("PASS");
            }
        }
    }
}
