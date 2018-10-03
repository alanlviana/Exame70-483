using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_017_ParallelBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            var loopResult = Parallel.For(0, 1000, (i, loopStatus) =>
            {
                if (i == 500)
                {
                    loopStatus.Break();
                }

                Console.WriteLine(i);
            });


        }
    }
}
