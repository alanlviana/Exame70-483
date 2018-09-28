﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_006_UsandoThreadLocal
{
    class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => {
            return Thread.CurrentThread.ManagedThreadId;
        });

        static void Main(string[] args)
        {

            new Thread(() => {
                for(int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread A: {i}");
                }
            }).Start();
            new Thread(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine($"Thread B: {i}");
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
