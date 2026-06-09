namespace StringToInteger;

public class Solution
{
    public int MyAtoi(string s)
    {
        int sign = 1;
        long sum = 0;
        bool hasStartedParsing = false;

        foreach (char c in s)
        {
            if (!hasStartedParsing && char.IsWhiteSpace(c))
            {
                continue;
            }
            if (!hasStartedParsing && (c == '-' || c == '+'))
            {
                hasStartedParsing = true;
                if (c == '-')
                    sign = -1;
                continue;
            }

            if (char.IsDigit(c))
            {
                hasStartedParsing = true;

                int digit = c - '0';

                sum = sum * 10 + digit;

                if (sum >= int.MaxValue)
                    return sign == 1 ? int.MaxValue : int.MinValue;
            }
            else
            {
                break;
            }
        }
        return (int)sum * sign;
    }
}
