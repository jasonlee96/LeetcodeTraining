using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

      public string ToString()
        {
            string result = "[";

            result += $"{this.val}";

            var ptr = this.next;
            
            while(ptr != null)
            {
                result += $",{ptr.val}";
                ptr = ptr.next;
            }
            result += "]";
            return result;
        }
    }
    class Q2 : IQ<ListNode>
    {
        public ListNode l1;
        public ListNode l2;
        public Q2()
        {
            l1 = new ListNode();
            l1.val = 2;
            l1.next = new ListNode();
            l1.next.val = 4;
            l1.next.next = new ListNode();
            l1.next.next.val = 3;
            l2 = new ListNode();
            l2.val = 5;
            l2.next = new ListNode();
            l2.next.val = 6;
            l2.next.next = new ListNode();
            l2.next.next.val = 4;
        }
        
        public ListNode BestRun()
        {
            throw new NotImplementedException();
        }

        public ListNode Run()
        {
            var ptr1 = l1;
            var ptr2 = l2;

            var result = new ListNode();
            var resultPtr = result;

            int carry = 0;
            while(ptr1 != null || ptr2 != null || carry > 0)
            {
                int val = carry;
                carry = 0;

                if (ptr1 != null) val += ptr1.val;
                if (ptr2 != null) val += ptr2.val;

                if (val >= 10) carry = val / 10;

                val %= 10;

                if (ptr1 != null) ptr1 = ptr1.next;
                if (ptr2 != null) ptr2 = ptr2.next;

                resultPtr.val = val;
                if (ptr1 != null || ptr2 != null || carry > 0)
                {
                    resultPtr.next = new ListNode();
                    resultPtr = resultPtr.next;
                }
                
            }
            return result;
        }
    }
}
