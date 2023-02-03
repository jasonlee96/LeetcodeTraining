using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class Q1775 : IQ<int>
    {
        public int[] nums1 = new int[] { 6, 6 };
        public int[] nums2 = new int[] { 1 };
        public int BestRun()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            return MinOperations(nums1, nums2);
        }

        public int MinOperations(int[] nums1, int[] nums2)
        {
            if (nums1.Length * 6 < nums2.Length || nums1.Length > 6 * nums2.Length)
            {
                return -1;
            }
            if (nums1.Sum() == nums2.Sum()) return 0;

            // lets make nums1 < nums 2
            if (nums2.Sum() < nums1.Sum()) return MinOperations(nums2, nums1);


            int count = 0;
            //sort
            nums1 = nums1.OrderBy(x => x).ToArray();
            nums2 = nums2.OrderBy(x => x).ToArray();
            // make the largest move is to set 6 to smallest number in arr1, and set to 1 for largest number in arr2
            int num1Index = 0;
            int num2Index = nums2.Length-1;
            var sum1 = nums1.Sum();
            var sum2 = nums2.Sum();
            while(sum1 < sum2)
            {

                    if(num2Index < 0 || num1Index < nums1.Length && 6 - nums1[num1Index] > nums2[num2Index] - 1)
                    {
                        sum1 += 6 - nums1[num1Index++];
                    }
                    else
                    {
                        sum2 -= nums2[num2Index--] - 1;
                    }

                    count++;

            }

            return count;

        }


    }
}
