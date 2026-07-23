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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode next = current.next;  // Step 1: save next
            current.next = prev;           // Step 2: reverse pointer
            prev = current;                // Step 3: move prev
            current = next;                // Step 4: move current
        }            
        return prev;
    }
}