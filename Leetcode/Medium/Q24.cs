using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    /*
     24. Swap Nodes in Pairs
    Given a linked list, swap every two adjacent nodes and return its head. You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)
     */
    public class Q24 : IQ<ListNode>
    {

        public ListNode n = new ListNode()
        {
            val = 1,
            next= new ListNode()
            {
                val = 2,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4,
                        next = null
                    }
                }
            }
        };

        public ListNode BestRun()
        {
            throw new NotImplementedException();
        }

        public ListNode Run()
        {

            return SwapPairs(n);
        }

        public ListNode SwapPairs(ListNode head)
        {
            // return edge case
            if (head == null) return null;
            if (head.next == null) return head;

            
            var currentPoint = head;
            // first.next = lastSwap;
            //  second.next = first;
            var result = head.next;
            ListNode checkPoint = null;
            while(currentPoint != null)
            {
                var adjPoint = currentPoint.next;
                if (adjPoint == null) break;// last node;

                // swap logic
                var refNode = adjPoint.next;

                adjPoint.next = currentPoint;

                currentPoint.next = refNode;

                if(checkPoint != null) checkPoint.next = adjPoint;
                checkPoint = currentPoint; // store checkpoint which have to link with next set


                // already swapped, so just proceed to next
                currentPoint = currentPoint.next;
            }

            return result;
        }
    }
}
