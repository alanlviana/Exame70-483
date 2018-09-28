using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_011_UsandoMaisTaskContinueWith
{
    class Program
    {
        static void Main(string[] args)
        {

            var task = Task.Run(() =>
            {
                return 42;
            });

            task.ContinueWith((t) => {
                Console.WriteLine("Somente se cancelado.");
            }, TaskContinuationOptions.OnlyOnCanceled);

            task.ContinueWith((t) => {
                Console.WriteLine("Somente se falhar.");
            }, TaskContinuationOptions.OnlyOnFaulted);

            task.ContinueWith((t) =>
            {
                Console.WriteLine("Somente se rodar completamente.");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.ReadKey();
        }
    }
}
