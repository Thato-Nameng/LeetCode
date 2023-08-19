/**
  Definition for singly-linked list.**
  public class ListNode {
      int val;
      ListNode next;
      ListNode() {}
      ListNode(int val) { this.val = val; }
      ListNode(int val, ListNode next) { this.val = val; this.next = next; }
  }*/
 

class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0); // Create a starting point
        ListNode result = dummy;  // Start building the result here
        int rem = 0;  // Carry value when adding digits
        
        while (l1 != null || l2 != null){
            int tot = rem;
            if (l1 != null){
                tot += l1.val;
                l1 = l1.next; // Move to the next digit
            }            
            if (l2 != null){
                tot += l2.val;
                l2 = l2.next; // Move to the next digit
            }
            
            rem = tot /10; // Update carry for next addition
            result.next = new ListNode(tot % 10); // Add the digit to result
            result = result.next; // Move result pointer to the next digit
        }
        if (rem > 0){
           result.next = new ListNode(rem);
        }
        return dummy.next; // Return the actual result linked list

    }
}