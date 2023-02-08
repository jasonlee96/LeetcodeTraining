using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class Q45 : IQ<int>
    {
        public int[] nums = new int[]{ 2, 3, 1, 1, 4 };
        public int BestRun()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            return Jump(nums);
        }

        public int Jump(int[] nums)
        {
            // edge case
            int size = nums.Length;
            if (nums.Length <= 1 || nums[0] == 0) return 0;
            if (nums[0] >= size - 1) return 1;

            int[] step = new int[size];

           

            // DP solution, starts from last second element.
            for(int i = size-2; i >= 0; i--)
             {
                step[i] = 1 + step[i + 1];
                for (int j = 2; j <= nums[i]; j++)
                {
                    if (i + j > size - 1) break;
                    if (step[i] > 1 + step[i + j]) step[i] = 1 + step[i + j];
                }
                
            }

            return step[0];
        }
    }
}
