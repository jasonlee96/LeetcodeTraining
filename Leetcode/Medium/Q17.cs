using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    class Q17 : IQ<IList<string>>
    {
        public string digits = "";
        private static string[] keys = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        public IList<string> BestRun()
        {
            throw new NotImplementedException();
        }

        public IList<string> Run()
        {
            return LetterCombinations(digits);
        }

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> list = new List<string>();

            if (string.IsNullOrEmpty(digits)) return list;

            Recursive(list, "", digits, 0);

            return list;
        }

        public void Recursive(IList<string> list, string str, string digits, int currentIndex)
        {
            if(str.Length == digits.Length)
            {
                list.Add(str);
                return;
            }

            string combinations = keys[digits[currentIndex] - '0'];

            foreach(var i in combinations)
            {
                Recursive(list, str + i, digits, currentIndex + 1);
            }
        }
    }
}
