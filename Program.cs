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
        int lengthOfTheListNode = 0;

        ListNode current = head;

        while (current != null)
        {
            lengthOfTheListNode++;
            current = current.next;
        }

        Console.WriteLine("Length of the ListNode = " + lengthOfTheListNode);

        for (int i = 0; i < lengthOfTheListNode; i++)
        {
            if (i == lengthOfTheListNode - n)
            {
                current = current.next.next;
                i++;
            }
            else
            {
                current = current.next;
            }

        }

        return head;
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

        // current = head;
        // while (current != null)
        // {
        //     Console.WriteLine(current.val);
        //     current = current.next; // avance vers le prochain nœud
        // }

        Solution s = new Solution();
        s.RemoveNthFromEnd(head, 2);
    }
}
