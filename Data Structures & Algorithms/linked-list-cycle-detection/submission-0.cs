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
    public bool HasCycle(ListNode head) {
        var counter = 0;
        while(head != null)
        {
            head = head.next;
            counter++;
            if(counter > 1000)
                return true;
        }


        return false;
    }
}
