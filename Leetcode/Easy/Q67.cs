using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Q67 : IQ<string>
    {
        public string a = "11";
        public string b = "1";
        public string BestRun()
        {
            throw new NotImplementedException();
        }

        public string Run()
        {
            return AddBinary(a,b);
        }

        public string AddBinary(string a, string b)
        {
            string result = "";
            int aLength = a.Length - 1;
            int bLength = b.Length - 1;

            int carryBit = 0;
            while (carryBit > 0 || aLength >= 0 || bLength >= 0)
            {
                int sum = carryBit;

                if(aLength >= 0)
                {
                    sum += (int)a[aLength] - (int)'0';
                    aLength--;
                }
                if(bLength>= 0)
                {
                    sum += b[bLength] - (int)'0';
                    bLength--;
                }

                carryBit = sum > 1 ? 1 : 0;

                result = (sum == 2 || sum == 0 ? "0" : "1") + result;
            }
            return result;
        }
    }
}
