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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0)
        return head;

        // 1. Compute length and get tail
        ListNode tail = head;
        int length = 1;
        while (tail.next != null)
        {
            tail = tail.next;
            length++;
        }

        // 2. Normalize k
        k = k % length;
        if (k == 0) return head;

        // 3. Make it circular
        tail.next = head;

        // 4. Find new tail: (length - k - 1) steps from head
        int stepsToNewTail = length - k;
        ListNode newTail = head;
        for (int i = 1; i < stepsToNewTail; i++)
            newTail = newTail.next;

        // 5. New head is next of newTail
        ListNode newHead = newTail.next;

        // 6. Break the circle
        newTail.next = null;

        return newHead;
    }
}