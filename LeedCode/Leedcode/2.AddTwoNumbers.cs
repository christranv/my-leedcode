using LeedCode.Dtos;

namespace LeedCode.Leedcode;

public class AddTwoNumbers
{
    public ListNode Execute(ListNode l1, ListNode l2)
    {
        var firstNode = new ListNode();
        var temp = firstNode;
        var carry = 0;
        while (true)
        {
            var sum = 0;
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            var nextNode = new ListNode(0, null);
            sum += carry;
            carry = sum / 10;
            temp.val = sum % 10;
            if (l1 == null && l2 == null && carry == 0) break;
            temp.next = nextNode;
            temp = nextNode;
        }

        return firstNode;
    }
}