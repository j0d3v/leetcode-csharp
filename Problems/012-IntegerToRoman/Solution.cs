using System.Text;

namespace IntegerToRoman;

public class Solution
{
    public static readonly Dictionary<int, string> map = new()
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    };

    public string IntToRoman(int num)
    {
        StringBuilder sb = new();

        int pow = 1000;

        while (pow != 0)
        {
            int digit = num / pow;

            if (digit < 9 && digit > 5)
            {
                sb.Append(map[pow * 5]);
                digit %= 5;
            }
            if (digit <= 3)
            {
                while (digit-- > 0)
                    sb.Append(map[pow]);
            }
            else
            {
                sb.Append(map[pow * digit]);
            }

            num %= pow;
            pow /= 10;
        }

        return sb.ToString();
    }
}
