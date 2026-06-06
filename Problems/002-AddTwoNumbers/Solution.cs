namespace AddTwoNumbers;
using Utils.LinkedList;
public class Solution
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		ListNode? tail = new();
		ListNode current = tail;

		int carry = 0;
		while (l1 != null || l2 != null || carry != 0)
		{
			int n1 = 0;
			int n2 = 0;
			if (l1 != null)
			{
				n1 = l1.val;
				l1 = l1.next;
			}
			if (l2 != null)
			{
				n2 = l2.val;
				l2 = l2.next;
			}
			int sum = n1 + n2 + carry;
			carry = sum / 10;
			current.next = new ListNode(sum % 10);
			current = current.next;
		}
		return tail.next;
	}
}
