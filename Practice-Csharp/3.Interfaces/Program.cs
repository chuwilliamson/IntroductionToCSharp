using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    class Program
    {
        static void Test(List<ILoggable> loggables)
        {
            loggables.ForEach(l => l.Log());
        }

        static void Main(string[] args)
        {
            var c = new Combat();
            c.Start();
            Console.ReadLine();

        }
    }
}
