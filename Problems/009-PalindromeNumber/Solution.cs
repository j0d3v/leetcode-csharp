using System;

namespace PalindromeNumber;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x < 10)
            return true;

        int reverse = 0;

        int y = x;
        while (y != 0)
        {
            reverse = reverse * 10 + y % 10;
            y /= 10;
        }
        return x == reverse;
    }
}
