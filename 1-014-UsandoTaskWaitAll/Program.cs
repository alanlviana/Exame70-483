using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_014_UsandoTaskWaitAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Task<int>[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 10;
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 20;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 30;
            });

            Task.WaitAll(tasks);

        }
    }
}
