namespace ReverseInteger;

record TestCase(int Input, int Expected);

public static class Tests
{
    public static void Main()
    {
        TestCase[] tests =
        [
            new(123, 321),
            new(-123, -321),
            new(120, 21),
            new(0, 0),
            new(1534236469, 0),
            new(-2147483648, 0),
            new(1463847412, 2147483641),
        ];

        for (int i = 0; i < tests.Length; i++)
        {
            Solution s = new();
            var got = s.Reverse(tests[i].Input);

            Console.Write($"#{i} => ");

            if (got != tests[i].Expected)
            {
                Console.WriteLine($"FAIL: expected {tests[i].Expected}, got {got}");
            }
            else
            {
                Console.WriteLine("PASS");
            }
        }
    }
}
