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
    public int PairSum(ListNode head) {
        return GetPairSumOptimizedVersion(head);
    }

    /// Solution with 2 pass (1 pass to find middle of list and 
    /// reverse the first hallf same time, second to cound max sum)
    public int GetPairSumOptimizedVersion(ListNode head)
    {
        int ans = 0;
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            // rever the nodes
            var next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;				
        }
        while(slow != null)
        {
            ans = Math.Max(ans, slow.val + prev.val);
            slow = slow.next;
            prev = prev.next;
        }
        return ans;
    }

    /// solution with thre pass (1 pass to find middle of list, 
    /// second to reverse second half, third to cound max sum)
    public int GetPairSum(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        int ans = 0;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        fast = head;// start from first
        //reverse second half
        slow = ReverseList(slow);
        while(fast != null && slow != null)
        {
            var newValue = fast.val + slow.val;
            if(newValue > ans)
                ans = newValue;
            fast = fast.next;
            slow = slow.next;
        }
        return ans;
    }

    public ListNode ReverseList(ListNode head)
    {
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