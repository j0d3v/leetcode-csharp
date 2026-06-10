using System;

namespace LongestCommonPrefix;

record TestCase(string[] Input, string Expected);

public static class Tests
{
	public static void Main()
	{
		TestCase[] tests =
		{
			new(new[] { "flower", "flow", "flight" }, "fl"),
			new(new[] { "dog", "racecar", "car" }, ""),
			new(new[] { "interspecies", "interstellar", "interstate" }, "inters"),
			new(new[] { "throne", "throne" }, "throne"),
			new(new[] { "a" }, "a"),
			new(new[] { "abc", "abc", "abc" }, "abc"),
			new(new[] { "ab", "a" }, "a"),
			new(new[] { "cir", "car" }, "c"),
		};

		var solution = new Solution();

		for (int i = 0; i < tests.Length; i++)
		{
			var got = solution.LongestCommonPrefix(tests[i].Input);

			Console.Write($"#{i} => ");

			if (got != tests[i].Expected)
				Console.WriteLine($"FAIL: expected [{tests[i].Expected}], got [{got}]");
			else
				Console.WriteLine("PASS");
		}
	}
}
