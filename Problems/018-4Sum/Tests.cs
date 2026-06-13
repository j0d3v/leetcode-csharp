namespace FourSum;

record TestCase(int[] Input, int Target, int[][] Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new([-2, -1, 0, 0, 1, 2], 0, [[-2, -1, 1, 2], [-2, 0, 0, 2], [-1, 0, 0, 1]]),
            new([2, 2, 2, 2, 2], 8, [[2, 2, 2, 2]]),
            new([], 0, []),
            new([1, 2, 3], 6, []),
            new([0, 0, 0, 0], 0, [[0, 0, 0, 0]]),
            new([-3, -1, 0, 2, 4, 5], 2, [[-3, -1, 2, 4]]),
            new([1, 1, 1, 1], 4, [[1, 1, 1, 1]]),
            new([5, 7, 1, -2], 100, []),
        ];

        Solution s = new();

        for (int i = 0; i < tests.Length; i++)
        {
            var got = s.FourSum(tests[i].Input, tests[i].Target);

            Console.Write($"#{i} => ");

            if (!Equal(got, tests[i].Expected))
                Console.WriteLine(
                    $"FAIL: expected [{Format(tests[i].Expected)}], got [{Format(got)}]"
                );
            else
                Console.WriteLine("PASS");
        }
    }

    static bool Equal(IList<IList<int>> actual, int[][] expected)
    {
        var actualSet = actual
            .Select(t => string.Join(",", t.OrderBy(x => x)))
            .ToHashSet();

        var expectedSet = expected
            .Select(t => string.Join(",", t.OrderBy(x => x)))
            .ToHashSet();

        return actualSet.SetEquals(expectedSet);
    }

    static string Format(int[][] triplets) =>
        string.Join(", ",
            triplets.Select(t =>
                $"[{string.Join(", ", t.OrderBy(x => x))}]"));

    static string Format(IList<IList<int>> triplets) =>
        string.Join(", ",
            triplets.Select(t =>
                $"[{string.Join(", ", t.OrderBy(x => x))}]"));
}
