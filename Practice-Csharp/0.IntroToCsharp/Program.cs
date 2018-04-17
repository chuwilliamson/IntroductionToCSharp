using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0.IntroToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            BusterSword sword = new BusterSword();
            sword.Attack = 15;
            string name = "matthewmatthewmatthewmatthewmatthewmatthewmatthewmatthewmatthewmatthewmatthewmatthewmatthew";
            foreach (var n in name)
                Console.WriteLine(n + " ");
            Console.ReadLine();
            
        }
    }
}
