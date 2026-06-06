namespace MedianOfTwoSortedArrays
{
    public class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];
            int left = 0;
            int index = 0;
            int right = 0;

            while (left < nums1.Length && right < nums2.Length)
            {
                nums[index++] = nums1[left] < nums2[right] ? nums1[left++] : nums2[right++];
            }
            while (left < nums1.Length)
            {
                nums[index++] = nums1[left++];
            }
            while (right < nums2.Length)
            {
                nums[index++] = nums2[right++];
            }

            int middle = index / 2;
            if (index % 2 == 0)
            {
                return (nums[middle] + nums[middle - 1]) / 2.0;
            }

            return nums[middle];
        }
    }
}
