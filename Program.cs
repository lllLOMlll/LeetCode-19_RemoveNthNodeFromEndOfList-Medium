using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Markup;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode fast = dummy;
        ListNode slow = dummy;

        for (int i = 0; i <= n; i++)
        {
            fast = fast.next;
        }

        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }

    static void Main(string[] arg)
    {
        // ListNode head = new ListNode(1);
        // head.next = new ListNode(2);
        // head.next.next = new ListNode(5);

        int[] values = { 1, 2, 3, 4, 5 };
        ListNode head = new ListNode(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        current = head;
        
        Solution s = new Solution();
        ListNode resultListNode = new ListNode();
        resultListNode = s.RemoveNthFromEnd(head, 2);

    
        current = resultListNode;
        while (current != null)
        {
            Console.WriteLine(current.val);
            current = current.next; // move to the next node
        }

      
    }
}
