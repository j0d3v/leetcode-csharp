namespace RemoveNthNodeFromEndOfList;

using Utils.LinkedList;

record TestCase(int[] Head, int N, int[] Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new([1, 2, 3, 4, 5], 2, [1, 2, 3, 5]),
            new([1], 1, []),
            new([1, 2], 1, [1]),
            new([1, 2], 2, [2]),
            new([1, 2, 3], 3, [2, 3]),
            new([10, 20, 30, 40, 50], 5, [20, 30, 40, 50]),
        ];

        var solution = new Solution();

        for (var i = 0; i < tests.Length; i++)
        {
            var test = tests[i];

            var head = ListNode.FromArray(test.Head);
            var got = solution.RemoveNthFromEnd(head!, test.N);

            var expected = ListNode.FromArray(test.Expected);

            Console.Write($"#{i} => ");

            Console.WriteLine(
                Equals(got, expected)
                    ? "PASS"
                    : $"FAIL: expected {expected}, got {got}"
            );
        }
    }
}
