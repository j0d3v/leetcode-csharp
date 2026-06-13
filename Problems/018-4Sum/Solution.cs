namespace FourSum;

public sealed class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        if (nums.Length < 4)
            return [];

        Array.Sort(nums);

        List<IList<int>> result = [];
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                int left = j + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                    if (sum < target) left++;
                    else if (sum > target) right--;
                    else
                    {
                        result.Add([nums[i], nums[j], nums[left], nums[right]]);

                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                }
            }
        }

        return result;
    }
}
