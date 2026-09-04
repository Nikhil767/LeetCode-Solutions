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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        // Push digits of l1
        while (l1 != null)
        {
            s1.Push(l1.val);
            l1 = l1.next;
        }

        // Push digits of l2
        while (l2 != null)
        {
            s2.Push(l2.val);
            l2 = l2.next;
        }

        int carry = 0;
        ListNode result = null;

        // Add until both stacks empty + carry
        while (s1.Count > 0 || s2.Count > 0 || carry > 0)
        {
            int sum = carry;

            if (s1.Count > 0) sum += s1.Pop();
            if (s2.Count > 0) sum += s2.Pop();

            carry = sum / 10;

            // Create new node at the front
            ListNode newNode = new ListNode(sum % 10);
            newNode.next = result;
            result = newNode;
        }

        return result;
    }
}