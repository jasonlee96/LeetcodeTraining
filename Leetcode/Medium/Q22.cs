using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    class Q22 : IQ<IList<string>>
    {
        public int n = 3;
        public IList<string> BestRun()
        {
            throw new NotImplementedException();
        }

        public IList<string> Run()
        {
            return GenerateParenthesis(n);
        }
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = new List<string>();

            Recursive(list, "", n, 0);
            return list;
        }

        public void Recursive(IList<string> list, string str, int left, int right)
        {
            if(left == 0 && right == 0)
            {
                list.Add(str);
                return;
            }

            if (right > 0) Recursive(list, str + ")", left, right - 1);

            if (left > 0) Recursive(list, str + "(", left-1, right + 1);
        }
        
    }
}
