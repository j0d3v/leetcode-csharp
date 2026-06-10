using System;

namespace RomanToInteger;

record TestCase(string Input, int Expected);

public static class Tests
{
	public static void Main()
	{
		TestCase[] tests =
		{
			new("I", 1),
			new("III", 3),
			new("IV", 4),
			new("IX", 9),
			new("LVIII", 58),
			new("MCMXCIV", 1994),
			new("MMMCMXCIX", 3999),
			new("XL", 40),
			new("XC", 90),
			new("CD", 400),
			new("CM", 900),
		};

		var solution = new Solution();

		for (int i = 0; i < tests.Length; i++)
		{
			var got = solution.RomanToInt(tests[i].Input);

			Console.Write($"#{i} => ");

			if (got != tests[i].Expected)
				Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
			else
				Console.WriteLine("PASS");
		}
	}
}