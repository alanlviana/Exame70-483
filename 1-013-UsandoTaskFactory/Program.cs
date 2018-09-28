using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_013_UsandoTaskFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(() =>
            {
                var valores = new int[3];

                var ft = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                ft.StartNew(() => valores[0] = 10);
                ft.StartNew(() => valores[1] = 20);
                ft.StartNew(() => valores[2] = 30);

                return valores;

            });

            var finalTask = task.ContinueWith((t) =>
            {
                foreach (int i in t.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
            Console.ReadKey();


        }
    }
}
