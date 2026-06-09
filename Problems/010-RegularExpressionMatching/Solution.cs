namespace RegularExpressionMatching;

public class Solution
{
    public bool IsMatch(string s, string p)
    {
        Stack<(int i, int k)> stack = new();
        stack.Push((0, 0));

        HashSet<(int, int)> visited = [];

        while (stack.Count > 0)
        {
            var (i, k) = stack.Pop();

            if (!visited.Add((i, k)))
                continue;

            if (i == p.Length)
            {
                if (k == s.Length)
                    return true;
                continue;
            }

            if (i + 1 < p.Length && p[i + 1] == '*')
            {
                char c = p[i];

                stack.Push((i + 2, k));

                if (k < s.Length && (c == '.' || s[k] == c))
                    stack.Push((i, k + 1));
            }
            else
            {
                if (k < s.Length && (p[i] == '.' || p[i] == s[k]))
                {
                    stack.Push((i + 1, k + 1));
                }
            }
        }

        return false;
    }
}
