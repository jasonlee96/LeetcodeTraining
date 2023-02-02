using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Others
{
    class CheckDownload
    {
        public static int runningTask { get; set; }
        public CheckDownload()
        {
            runningTask = 0;
        }
        public string BestRun()
        {
            throw new NotImplementedException();
        }
        
        public async Task<string> Run(int i)
        {

            if(runningTask >= 2)
            {
                Console.WriteLine("Too Many Downloads");
            }
            else
            {
                runningTask++;
                Console.WriteLine("Downloading Task {0}", i);
                await Task.Delay(5000);
                Console.WriteLine("Download Complete {0}", i);
                runningTask--;
               
            }
            return  "";
        }
    }
}
