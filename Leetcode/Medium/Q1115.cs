using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    // https://leetcode.com/problems/print-foobar-alternately/

    public class Q1115
    {
        private int n;
        private Semaphore s;
        private Semaphore s1;

        public Q1115(int n)
        {
            this.n = n;
            s = new Semaphore(0, n);
            s1 = new Semaphore(1, n + 1);
        }

        public void Foo(Action printFoo)
        {

            for (int i = 0; i < n; i++)
            {
                s1.WaitOne();
                            // printFoo() outputs "foo". Do not change or remove this line.
                            printFoo();
                s.Release();              
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                s.WaitOne();
                            // printFoo() outputs "foo". Do not change or remove this line.
                            printBar();
                s1.Release();
                
            }
        }
    }
}
