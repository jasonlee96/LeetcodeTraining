using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class Q20 : IQ<bool>
    {
        public string s = "((";
        //public static string s = "(]";
        //public static string s = "([)]";
        //public static string s = "{[]}";

        /***
         * 
         
        Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.

         *
         ***/
        public bool Run()
        {
            // use stack to solve this.
            Stack<int> stacks = new Stack<int>();
            foreach(var i in s)
            {
                if (stacks.Count == 0)
                {
                    // if start with closed bracket/ parenthesis means invalid
                    if (i == ']' || i == '}' || i == ')') return false;
                    stacks.Push((int)i);
                    continue;
                }

                int currInt = (int)i;
                if(currInt == 41 || currInt == 93 || currInt == 125)
                {
                    int diff = currInt - 2 - stacks.First();

                    if(diff >= -1 && diff <= 1)
                    {
                        stacks.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stacks.Push(currInt);
                }
            }
            if (stacks.Count > 0) return false;
            return true;
        }

        public bool BestRun()
        {
            Stack<int> stacks = new Stack<int>();

            // if it is not even string then it is invalid.
            if (s.Length % 2 != 0) return false;

            foreach(var i in s)
            {
                if (i == '(') stacks.Push(')');
                else if (i == '{') stacks.Push('}');
                else if (i == '[') stacks.Push(']');
                else if (stacks.Count == 0 || stacks.Pop() != i) return false;
            }
            
            if (stacks.Count > 0) return false;
            return true;
        }
    }
}
