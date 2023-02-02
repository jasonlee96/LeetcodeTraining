using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public interface IQ<T>
    {
        public T Run();
        public T BestRun();
    }
}
