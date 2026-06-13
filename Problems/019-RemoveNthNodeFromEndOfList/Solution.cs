namespace RemoveNthNodeFromEndOfList;

using Utils.LinkedList;

public class Solution
{
    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        int distanceFromEnd = Remove(head, n);

        // If the removed node is the head
        return distanceFromEnd == n ? head?.next : head;
    }

    private static int Remove(ListNode? node, int n)
    {
        if (node == null) return 0;

        int positionFromEnd = Remove(node.next, n) + 1;

        // If next node is the target, skip it
        if (positionFromEnd == n + 1) node.next = node.next?.next;

        return positionFromEnd;
    }
}
