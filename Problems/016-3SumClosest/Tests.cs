namespace ThreeSumClosest;

record TestCase(int[] Input, int Target, int Expected);

public static class Tests
{
	public static void Main()
	{
		TestCase[] tests =
		[
			new([-1, 2, 1, -4], 1, 2),
			new([0, 0, 0], 1, 0),
			new([1, 1, 1, 0], -100, 2),
			new([0, 2, 1, -3], 1, 0),
			new([-1000, -1000, -1000, 1000, 1000, 1000], 1, 1000),
		];

		Solution s = new();

		for (int i = 0; i < tests.Length; i++)
		{
			var got = s.ThreeSumClosest(
				tests[i].Input,
				tests[i].Target
			);

			Console.Write($"#{i} => ");

			if (got != tests[i].Expected)
				Console.WriteLine(
					$"FAIL: expected {tests[i].Expected}, got {got}"
				);
			else
				Console.WriteLine("PASS");
		}
	}
}
