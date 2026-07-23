/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head is null || head.next == null) return null;
        ListNode prev = null;
        ListNode current = head;			
        ListNode fast = current;
        while (fast != null && fast.next != null)
        {
            prev = current;
            current = current.next;
            fast = fast.next.next;								
        }
        if (prev is not null && prev.next is not null)
        {
            ListNode next = prev.next;
            prev.next = next.next;
            next.next = null;
        }
        return head;
    }
}