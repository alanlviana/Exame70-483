﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_002_ThreadBackground
{
    class Program
    {
        public static void ThreadMethod() {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            // Com Essa linha a aplicação finaliza a thread no fim da thread principal.
            // Sem ela a aplicação esperaria a thread terminar para finalizar.
            t.IsBackground = true;
            t.Start();
        }
    }
}
