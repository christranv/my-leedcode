using LeedCode.Dtos;

namespace LeedCode.Leedcode;

public class SwapPairs
{
    public ListNode Execute(ListNode head)
    {
        if (head == null) return null;
        ListNode starter = new ListNode(0, head);
        ListNode pointer = starter.next;
        ListNode tail = starter;
        while (pointer is { next: not null })
        {
            var swap = pointer.next;
            pointer.next = swap.next;
            swap.next = pointer;
            if (tail != null) tail.next = swap;
            tail = pointer;
            pointer = pointer.next;
        }

        return starter.next;
    }
}