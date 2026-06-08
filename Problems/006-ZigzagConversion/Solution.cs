using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        StringBuilder sb = new();

        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < s.Length; j += (numRows - 1) * 2)
            {
                sb.Append(s[j]);

                if (i != 0 && i != numRows - 1 && j + (numRows - i - 1) * 2 < s.Length)
                    sb.Append(s[j + (numRows - i - 1) * 2]);
            }
        }

        return sb.ToString();
    }
}
