using System;

namespace ContainerWithMostWater;

record TestCase(int[] Input, int Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        {
            new(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49),
            new(new[] { 1, 1 }, 1),
            new(new[] { 4, 3, 2, 1, 4 }, 16),
            new(new[] { 1, 2, 1 }, 2),
            new(new[] { 2, 3, 4, 5, 18, 17, 6 }, 17),
            new(new[] { 1, 3, 2, 1, 3 }, 9),
        };

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.MaxArea(tests[i].Input);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            else
                Console.WriteLine("PASS");
        }
    }
}
