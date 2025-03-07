using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Q326 : IQ<bool>
    {
        public int n = 27;

        public bool BestRun()
        {
            throw new NotImplementedException();
        }

        public bool Run()
        {
            if (n < 1) return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}
