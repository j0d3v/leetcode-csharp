namespace TwoSum;
public class Solution
{
	public static int[] TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> diff = [];

		for (int i = 0; i < nums.Length; i++)
		{
			if (diff.TryGetValue(nums[i], out int value))
				return [value, i];

			diff[target - nums[i]] = i;
		}

		return [];
	}
}