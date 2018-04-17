using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface ILoggable
    {
        string Name { get; set; }
        void Log();
    }
    public class Animal : ILoggable
    {
        string name;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public void Log()
        {
            Console.WriteLine("My name is " + name + " i am an aminal");
        }
    }

    public class Vehicle : ILoggable
    {
        string name;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public void Log()
        {
            Console.WriteLine("my name is " + name + " vroom vroom ");
        }
    }

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
