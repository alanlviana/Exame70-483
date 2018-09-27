using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_005_UsandoThreadStaticAttribute
{
    class Program
    {
        [ThreadStatic]
        public static int _campo;

        static void Main(string[] args)
        {
            // Thread A
            new Thread(() =>
            {
                for(int i = 0; i< 10; i++)
                {
                    _campo++;
                    Console.WriteLine("Thread A: {0}", _campo);
                }
            }).Start();

            // Thread B
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _campo++;
                    Console.WriteLine("Thread B: {0}", _campo);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
