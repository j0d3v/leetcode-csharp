namespace AddTwoNumbers;
using Utils.LinkedList;

record TestCase(ListNode Nums, ListNode Target, ListNode Expected);

public static class Tests
{
	public static void Main()
	{
		TestCase[] tests =
		[
			new(
		ListNode.FromArray([2,4,3])!,
		ListNode.FromArray([5,6,4])!,
		ListNode.FromArray([7,0,8])!
	),
	new(
		ListNode.FromArray([0])!,
		ListNode.FromArray([0])!,
		ListNode.FromArray([0])!
	),
	new(
		ListNode.FromArray([9,9,9,9,9,9,9])!,
		ListNode.FromArray([9,9,9,9])!,
		ListNode.FromArray([8,9,9,9,0,0,0,1])!
	)
		];

		for (int i = 0; i < tests.Length; i++)
		{
			Solution s = new();
			var got = s.AddTwoNumbers(tests[i].Nums, tests[i].Target);

			Console.Write($"#{i} => ");

			if (!got.Equals(tests[i].Expected))
			{
				Console.WriteLine(
					$"FAIL: expected {tests[i].Expected}, " +
					$"got {got}");
			}
			else
			{
				Console.WriteLine("ok");
			}
		}
	}
}