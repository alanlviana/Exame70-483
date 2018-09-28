using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_007_TrabalhandoComThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine($"Thread X: {Thread.CurrentThread.ManagedThreadId}");
            });
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine($"Thread X: {Thread.CurrentThread.ManagedThreadId}");
            });

            Console.ReadKey();

        }
    }
}
