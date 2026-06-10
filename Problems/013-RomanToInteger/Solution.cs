using System.Text;

namespace RomanToInteger;

public class Solution
{
	public static readonly Dictionary<char, int> map = new()
	{
		{ 'M',1000 },
		{ 'D',500 },
		{ 'C',100 },
		{ 'L',50 },
		{ 'X', 10},
		{ 'V', 5},
		{ 'I', 1},
	};
	public int RomanToInt(string s)
	{
		if (s.Length == 1) return map[s[0]];

		int prev = 0;
		int sum = 0;
		foreach (char c in s)
		{
			int current = map[c];
			if (current > prev)
			{
				sum -= 2 * prev;
			}
			sum += current;
			prev = current;
		}
		return sum;
	}
}
