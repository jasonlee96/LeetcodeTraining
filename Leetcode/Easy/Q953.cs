using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    /*
     * 953. Verifying an Alien Dictionary
     * 
     * In an alien language, surprisingly, they also use English lowercase letters, but possibly in a different order. The order of the alphabet is some permutation of 
     * lowercase letters.

Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographically in this 
    alien language.
     */
    public class Q953 : IQ<bool>
    {
        public string[] words = new[] { "apap", "app" };
        public string order = "abcdefghijklmnopqrstuvwxyz";
        public bool BestRun()
        {
            throw new NotImplementedException();
        }

        public bool Run()
        {
            return IsAlienSorted(words, order);
        }
        public bool IsAlienSorted(string[] words, string order)
        {
            if (words.Length <= 1) return true;

            for(int i = 1; i < words.Length; i++)
            {
                bool identical = false;
                // loop characters
                for(int j = 0; j < words[i-1].Length; j++)
                {
                    try
                    {
                        if (order.IndexOf(words[i][j]) > order.IndexOf(words[i - 1][j]))
                        {
                            break;
                        }


                        if (order.IndexOf(words[i][j]) < order.IndexOf(words[i - 1][j]))
                        {
                            return false;
                        }

                        identical = true;
                    }
                    catch
                    {
                        return identical;
                    }
                    //if (words[i].Length != words[i-1].Length && words[i].Length == j+1) return false; // if next word is shorter and current character is identical. 

                }
            }

            return true;
        }
    }
}
