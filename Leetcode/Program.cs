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
            //await ConcurrentTask();
            var Question = new Q191();

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
        public static async Task ConcurrentTask()
        {
            int n = 2;
            var Q = new Q1115(n);

            List<Task> tasks = new List<Task>();

            for(int i = 0; i <n; i++)
            {
                tasks.Add(Task.Run(() => Q.Bar(() => Console.Write("bar"))));

                tasks.Add(Task.Run(() => Q.Foo(() => Console.Write("foo"))));
            }

            await Task.WhenAll(tasks);

        }
    }
}
