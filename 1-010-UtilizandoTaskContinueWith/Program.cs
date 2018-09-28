using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_010_UtilizandoTaskContinueWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(() =>
            {
                return 21;
            }).ContinueWith((t) =>
            {
                return t.Result * 2;
            });

            Console.WriteLine($"A respostas para tudo mais continua sendo {task.Result}");
            Console.ReadKey();

        }
    }
}
