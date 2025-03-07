using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Q191 : IQ<int>
    {
        public int n = 11;
        public int BestRun()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            int count = 0;
            while (n > 0)
            {
                count += (int)(n & 1); // Check last bit
                n >>= 1; // Shift right
            }
            return count;
        }
    }
}
