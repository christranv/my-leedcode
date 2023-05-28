using LeedCode.Dtos;

namespace LeedCode.Leedcode;

public class RemoveNthFromEnd
{
    /// <summary>
    /// Optimized solution is 2 pointer.
    /// Keep N distance between 2 pointer to find the node that need to be removed.
    /// </summary>
    public ListNode Execute(ListNode head, int n)
    {
        var follower = head;
        var leader = head;
        var counter = 0;
        while (leader != null)
        {
            if (counter > n)
                follower = follower.next;
            leader = leader.next;
            counter++;
        }

        if (follower == head && counter == n) return follower.next;

        follower.next = follower.next.next;
        return head;
    }

    /// <summary>
    /// My O(N) solution. Easy to code, but space complexity is O(N)
    /// </summary>
    public ListNode ExecuteMySolution(ListNode head, int n)
    {
        if (head.next is null)
            return null;
        var list = new List<ListNode>();
        var node = head;
        while (node != null)
        {
            list.Add(node);
            node = node.next;
        }

        if (list.Count == n) return head.next;
        list[^(n + 1)].next = list[^n].next;
        return head;
    }
}