using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Q136 : IQ<int>
    {
        public int[] nums = new int[]
        {
            2, 4, 3, 2,4
        };

        /***
         * 
         
        Given an integer array nums where every element appears twice except for one, which appears exactly once. Find the single element and return it.

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

            int ones = 0;
            // solution is to XOR logic to get A XOR A! = A
            // 0 -> 1 -> 0
            // 0000 -> 0001 -> 0000
            foreach (var i in nums)
            {
                ones = (ones ^ i);
            }
            return ones;
        }
    }
}
