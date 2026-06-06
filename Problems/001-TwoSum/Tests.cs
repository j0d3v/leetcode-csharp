namespace TwoSum;
record TestCase(int[] Nums, int Target, int[] Expected);

public static class Tests
{
	public static void Main()
	{
		TestCase[] tests =
		[
			new([2, 7, 11, 15], 9, [0, 1]),
			new([3, 2, 4], 6, [1, 2]),
			new([3, 3], 6, [0, 1]),
		];

		for (int i = 0; i < tests.Length; i++)
		{
			var got = Solution.TwoSum(tests[i].Nums, tests[i].Target);

			Console.Write($"#{i} => ");

			if (!got.SequenceEqual(tests[i].Expected))
			{
				Console.WriteLine(
					$"FAIL: expected [{string.Join(", ", tests[i].Expected)}], " +
					$"got [{string.Join(", ", got)}]");
			}
			else
			{
				Console.WriteLine("ok");
			}
		}
	}
}