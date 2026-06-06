namespace LongestSubstring;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 1)
            return 0;

        HashSet<char> set = [];

        int left = 0;
        int right = 0;
        int max = 0;

        while (right < s.Length && left <= right)
        {
            if (!set.Contains(s[right]))
            {
                set.Add(s[right]);
                max = Math.Max(max, right - left + 1);
                right++;
            }
            else
            {
                set.Remove(s[left]);
                left++;
            }
        }

        return max;
    }
}
