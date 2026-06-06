namespace MedianOfTwoSortedArrays;

record TestCase(int[] Nums1, int[] Nums2, double Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new([1, 3], [2], 2.0),
            new([1, 2], [3, 4], 2.5),
            new([], [1], 1.0),
            new([1], [], 1.0),
            new([0, 0], [0, 0], 0.0),
            new([2], [], 2.0),
            new([1, 3, 8], [7, 9, 10], 7.5),
            new([1, 2, 3], [4, 5, 6, 7], 4.0),
            new([1, 2], [3], 2.0),
            new([1, 2, 3, 4, 5], [6, 7, 8, 9, 10], 5.5),
            new([-5, -3, -1], [1, 3, 5], 0.0),
            new([-10, -5, 0, 5, 10], [100], 2.5),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = Solution.FindMedianSortedArrays(tests[i].Nums1, tests[i].Nums2);

            Console.Write($"#{i} => ");

            if (Math.Abs(got - tests[i].Expected) > 1e-6)
            {
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
    }
}
