using System.Text;

namespace LongestCommonPrefix;

public class Solution
{
	public string LongestCommonPrefix(string[] strs)
	{
		int min = strs[0].Length;
		for (int i = 0; i < strs.Length; i++)
		{
			int j = 0;

			while (j < min && j < strs[i].Length && strs[i][j] == strs[0][j])
				j++;

			min = j;
		}
		if (min == 0)
			return "";
		return strs[0].Substring(0, min);
	}
}
