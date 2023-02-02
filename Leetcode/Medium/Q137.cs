using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class Q137 : IQ<int>
    {
        public int[] nums = new int[]
        {
            2, 4, 3, 2,2,4,4
        };

        /***
         * 
         
        Given an integer array nums where every element appears three times except for one, which appears exactly once. Find the single element and return it.

        You must implement a solution with a linear runtime complexity and use only constant extra space.

         *
         ***/
        public int BestRun()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            if (nums.Length == 1) return nums[0];
            /***
             eg. y = 1001, lets try to insert three times (logic is to control the bit 00 -> 01 -> 10 -> 00) when insert three times then reset to 0.
                then, ended up we can get the num that only appear once.
            Add 1st y
             first stage calculate ones
             ones = XOR logic 0 ^ y 0000 ^ 1001 = 1001
             bitwise  ~twos = ~0 = 1111
             ones & ~twos = 1001 & 1111 = 1001

             second stage update twos
             twos = XOR 0 ^ y 0000 ^ 1001 = 1000
             bitwise ~ones = ~1001 = 0110
             twos & ~ones = 1000 & 0110 = 0000

            Add 2nd y
             first stage calculate ones
             ones = XOR 1001 ^ 1001 = 0000
             bitwise  ~twos = ~0000 = 1111
             ones & ~twos = 0000 & 1111 = 0000

             second stage update twos
             twos = XOR 0000 ^ 1001 = 1001
             bitwise ~ones = ~0000 = 1111
             twos & ~ones = 1001 & 1111 = 1001

            Add 3rd y
             first stage calculate ones
             ones = XOR 0000 ^ 1001 = 1001
             bitwise  ~twos = ~1001 = 0110
             ones & ~twos = 1001 & 0110 = 0000 <-- after adding three times, our result will become 0 (so the logic is here)

             second stage update twos
             twos = XOR 1001 ^ 1001 = 0000
             bitwise ~ones = ~0000 = 1111
             twos & ~ones = 0000 & 1111 = 0000 
             
            so we can conclude ( x + 3y +3z +3k, we can still get back to x with this algorithm )
            // 
            ***/
            int ones = 0;
            int twos = 0;

            foreach(var i in nums)
            {
                ones = (ones ^ i) & ~twos;
                twos = (twos ^ i) & ~ones;
            }
            return ones;
        }
    }
}
