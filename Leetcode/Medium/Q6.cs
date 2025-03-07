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
            if(numOfRow == 1 || numOfRow >= input.Length)
            {
                return input;
            }
            int slicePoint = 2 * (numOfRow - 1);

            for(int row = 0; row < numOfRow; row++)
            {
                for (int i = row ; i < input.Length; i += slicePoint)
                {
                    result += input[i];
                    int secondIdx = i + slicePoint - (2 * row);
                    // eliminate first row and last row, as dont have diagonal character
                    if (row > 0 && row < numOfRow - 1 && secondIdx < input.Length)
                    {
                        result +=input[secondIdx];
                    }
                }
            }
            return result;
        }
    }
}
