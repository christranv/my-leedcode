using LeedCode.Dtos;

namespace LeedCode.Leedcode;

public class MergeTwoLists
{
    public ListNode Execute(ListNode list1, ListNode list2)
    {
        var head = new ListNode();
        var current = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        if (list1 != null)
            current.next = list1;
        else if (list2 != null)
            current.next = list2;

        // GC.Collect(); // If you want memory usage is min
        return head.next;
    }
}