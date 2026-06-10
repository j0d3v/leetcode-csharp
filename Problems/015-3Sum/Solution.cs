namespace ThreeSum;

public class Solution
{
	public IList<IList<int>> ThreeSum(int[] nums)
	{
		int right;
		int left;
		IList<IList<int>> result = [];
		Array.Sort(nums);
		for (int i = 0; i < nums.Length - 1; i++)
		{
			if (i > 0 && nums[i] == nums[i - 1]) continue;
			left = i + 1;
			right = nums.Length - 1;
			while (left < right)
			{
				int sum = nums[left] + nums[i] + nums[right];
				if (sum == 0)
				{
					result.Add([nums[left++], nums[i], nums[right--]]);
					while (left < right && nums[left] == nums[left - 1]) left++;
				}
				else if (sum < 0) left++;
				else right--;
			}
		}
		return result;
	}
}