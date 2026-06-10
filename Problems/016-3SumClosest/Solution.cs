namespace ThreeSumClosest;

public class Solution
{
	public int ThreeSumClosest(int[] nums, int target)
	{
		int closestSum = nums[0] + nums[1] + nums[2];
		Array.Sort(nums);
		for (int i = 0; i < nums.Length - 2; i++)
		{
			if (i > 0 && nums[i] == nums[i - 1]) continue;
			int right = nums.Length - 1;
			int left = i + 1;
			while (left < right)
			{
				int sum = nums[left] + nums[i] + nums[right];
				if (sum == target) return target;

				if (Math.Abs(target - sum) < Math.Abs(target - closestSum))
					closestSum = sum;

				if (sum < target) left++;
				else right--;

			}
		}
		return closestSum;
	}
}
