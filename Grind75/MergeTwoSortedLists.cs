namespace Grind75;

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public static class MergeTwoSortedLists
{
    public static ListNode? Run(ListNode list1, ListNode list2)
    {
        ListNode temp = new();
        ListNode current = temp;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next!;
            }
            else
            {
                current.next = list2;
                list2 = list2.next!;
            }

            current = current.next!;
        }

        if (list1 != null)
        {
            current.next = list1;
        }
        else if (list2 != null)
        {
            current.next = list2;
        }

        return temp.next;
    }
}
