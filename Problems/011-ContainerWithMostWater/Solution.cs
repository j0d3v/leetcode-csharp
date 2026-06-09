using System;

namespace ContainerWithMostWater;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int right = height.Length - 1;
        int left = 0;
        int area = 0;
        while (left <= right && right < height.Length && left >= 0)
        {
            if (height[left] > height[right])
            {
                area = (right - left) * height[right--];
            }
            else
            {
                area = (right - left) * height[left++];
            }
            if (area > maxArea)
                maxArea = area;
        }
        return maxArea;
    }
}
