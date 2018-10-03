using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_015_UsandoTaskWaitAny
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 10; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 20; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 30; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                var taskCompleta = tasks[i];

                Console.WriteLine(taskCompleta.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }

        }
    }
}
