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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Dummy node acts as a stable starting anchor
        ListNode dummy = new ListNode(-1);
        ListNode tail = dummy;

        // Traverse both lists and re-link nodes in ascending order
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                tail.next = list1;
                list1 = list1.next;
            } else {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }

        // Attach whatever is left of the non-empty list
        tail.next = (list1 != null) ? list1 : list2;

        // The actual head of the merged list is dummy.next
        return dummy.next;
    }
}