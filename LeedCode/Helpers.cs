using LeedCode.Dtos;

namespace LeedCode;

public static class Helpers
{
    public static ListNode GetNode(int[] arr)
    {
        if (arr.Length == 0) return null;
        var current = new ListNode(arr[0]);
        var head = current;
        for (var i = 1; i < arr.Length; i++)
        {
            current.next = new ListNode(arr[i]);
            current = current.next;
        }

        return head;
    }

    public static void Print(this ListNode list)
    {
        while (list != null)
        {
            Console.Write(list.val + ", ");
            list = list.next;
        }

        Console.WriteLine();
    }
}