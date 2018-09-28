using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_012_AnexandoTarefasFilhas
{
    class Program
    {
        static void Main(string[] args)
        {

            var taskPrincipal = Task.Run(() =>
            {
                var array = new Int32[3];
                var subTask = Task.Run(() => { array[0] = 42; });
                var subTask1 = Task.Run(() => { array[1] = 21; });
                var subTas2 = Task.Run(() => { array[2] = 84; });

                return array;
            });

            var finalTask = taskPrincipal.ContinueWith((t) =>
            {
                foreach(int i in t.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();



        }
    }
}
