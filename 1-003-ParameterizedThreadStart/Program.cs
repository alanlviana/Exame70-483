using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_003_ParameterizedThreadStart
{
    class Program
    {
        public static void ThreadMethod(object o) {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethod));
            thread.Start(5);
            thread.Join();

        }
    }
}
