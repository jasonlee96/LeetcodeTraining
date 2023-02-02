using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class Q3 : IQ<int>
    {
        public string n = "aau";
        public int BestRun()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            return LengthOfLongestSubstring(n);
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (s.Length <= 1) return s.Length;
            List<int> list = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();

                for(int j = i; j < s.Length; j++)
                {
                    if (dict.TryGetValue(s[j], out int match))
                    {
                        list.Add((j - i));
                        break;
                    }
                    
                    dict.Add(s[j], 1);

                    if (j == s.Length-1) list.Add((j - i)+1);
                }
            }
            return list.Count == 0 ? s.Length : list.Max();
        }
    }
}
