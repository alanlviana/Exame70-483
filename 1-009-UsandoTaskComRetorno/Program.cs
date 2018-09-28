using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_009_UsandoTaskComRetorno
{
    class Program
    {
        static void Main(string[] args)
        {

            var task = Task.Run(() =>
            {
                return 42;
            });

            Console.WriteLine($"A resposta para a vida, para o universo e para tudo mais é {task.Result}");

            Console.ReadKey();
        }
    }
}
