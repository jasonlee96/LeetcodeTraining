using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Leetcode.Easy;
using Leetcode.Medium;
using Leetcode.Others;

namespace Leetcode
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var Question = new Q45();

            var result = Question.Run();


            Console.WriteLine(result.ToString());


            //await RunAsync();

        }

        public static async Task RunAsync()
        {
            var others = new CheckDownload();
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 5; i++)
            {
                Task task = others.Run(i);
                await Task.Delay(1500);
                tasks.Add(task);
            }
            await Task.WhenAll(tasks);
        }
    }
}
