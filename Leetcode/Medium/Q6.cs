using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //https://leetcode.com/problems/zigzag-conversion/description/
    internal class Q6 : IQ<string>
    {
        // 2 -> 2, 3 -> 4, 4 -> 6 5 -> 8, 6 -> 10
        // 01234567890123
        // PAYPALISHIRING
        // 0 4 8 12 1 3 5 7 9 11 13 2 6 10
        // PAHNAPLSIIGYIR
        // 0 6 12 1 5 9 13 2 4 8 
        // PINALSIGYAHRPI
        public string input = "PAYPALISHIRING";
        public int numOfRow = 3;
        public string BestRun()
        {
            throw new NotImplementedException();
        }

        public string Run()
        {
            var result = "";
            result = GenerateZigZag(input, numOfRow);
            return result;
        }
        // recursive 
        public string GenerateZigZag(string s, int num, List<string> combs)
        {
            if (num == 1) return s;

            int lengthOfS = s.Length;
            int splitPoint = (num - 1) * 2;
            int splitIndex = 0;
            string result = "";
            List<string> combs = new List<string>();
            while (splitIndex < lengthOfS)
            {
                result += s.Substring(splitIndex, 1); // take every first letter;
                combs.Add(s.Substring(splitIndex + 1, splitIndex + splitPoint >= lengthOfS ? lengthOfS - 1 - splitIndex : splitPoint - 1));
                splitIndex += splitPoint;

            }
            foreach(var comb in combs)
            {
                result += GenerateZigZag(comb, num - 1);
            }
            return result;
        }
    }
}
