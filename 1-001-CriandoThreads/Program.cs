﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_001_CriandoThreads
{
    class Program
    {
        public static void ThreadMethod() {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Fazendo algum trabalho.");
                Thread.Sleep(0);
            }

            // Aguarda Thread terminar.
            t.Join();


        }
    }
}
