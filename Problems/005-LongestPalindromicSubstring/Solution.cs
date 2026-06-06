using System.Linq;

namespace LongestPalindromicSubstring;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int start = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            ExpandAroundCenter(s, ref start, ref end, i, i + 1); // if even offset by 1
            ExpandAroundCenter(s, ref start, ref end, i, i); // if odd no offset
        }
        return s.Substring(start, end - start);
    }

    public void ExpandAroundCenter(string s, ref int start, ref int end, int left, int right)
    {
        while (right < s.Length && left >= 0 && s[right] == s[left])
        {
            left--;
            right++;
        }
        if (right - left - 1 > end - start)
        {
            start = left + 1;
            end = right;
        }
    }
}
