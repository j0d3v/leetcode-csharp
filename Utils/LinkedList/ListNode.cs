using System.Text;

namespace Utils.LinkedList;

#nullable disable

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode FromArray(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array must not be empty");

        ListNode head = new ListNode(arr[0]);
        ListNode current = head;

        for (int i = 1; i < arr.Length; i++)
        {
            current.next = new ListNode(arr[i]);
            current = current.next;
        }

        return head;
    }

    public int[] ToArray()
    {
        List<int> result = new();
        ListNode current = this;

        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }

        return result.ToArray();
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append('[');

        ListNode current = this;

        while (current != null)
        {
            sb.Append(current.val);

            if (current.next != null)
                sb.Append(" -> ");

            current = current.next;
        }

        sb.Append(']');
        return sb.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj is not ListNode other)
            return false;

        ListNode a = this;
        ListNode b = other;

        while (a != null && b != null)
        {
            if (a.val != b.val)
                return false;

            a = a.next;
            b = b.next;
        }

        return a == null && b == null;
    }

    public override int GetHashCode()
    {
        int hash = 17;
        ListNode current = this;

        while (current != null)
        {
            hash = hash * 31 + current.val;
            current = current.next;
        }

        return hash;
    }
}