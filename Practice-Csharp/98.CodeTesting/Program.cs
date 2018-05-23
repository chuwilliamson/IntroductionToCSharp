using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeReview;

namespace _98.CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Program of what I feel you are trying to accomplish");
            var r = new Review().Runit();
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
