namespace ThreeSum;

record TestCase(int[] Input, int[][] Expected);

public static class Tests
{
	public static void Main()
	{
		TestCase[] tests =
		[
			new([-1, 0, 1, 2, -1, -4], [[-1, -1, 2], [-1, 0, 1]]),
			new([0, 1, 1], []),
			new([0, 0, 0], [[0, 0, 0]]),
			new([-2, 0, 0, 2, 2], [[-2, 0, 2]]),
			new([-2, -2, 0, 0, 2, 2], [[-2, 0, 2]]),
		];

		Solution s = new();

		for (int i = 0; i < tests.Length; i++)
		{
			var got = s.ThreeSum(tests[i].Input);

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