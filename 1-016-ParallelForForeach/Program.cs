using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_016_ParallelForForeach
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.For(1, 10, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("For>"+i);
            });

            var number = Enumerable.Range(0, 10);
            Parallel.ForEach(number, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Foreach>"+i);

            });

        }
    }
}
