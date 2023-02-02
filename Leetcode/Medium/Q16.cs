using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    class Q16 : IQ<int>
    {
        public int[] nums = new int[]
        {
            -1,2,1,-4
        };
        public int target = 1;
        public int BestRun()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            Array.Sort(nums);

            for(int i = 0; i < nums.Length - 1; i++)
            {
                int start = i + 1, end = nums.Length - 1;

                while (start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (sum < target)
                    {
                        start++;
                    }
                    else if (sum > target)
                    {
                        end--;
                    }
                    else
                    {
                        return sum;
                    }

                    if(Math.Abs(result - target) > Math.Abs(sum - target))
                    {
                        result = sum;
                    }
                }
            }
            return result;
        }
    }
}
