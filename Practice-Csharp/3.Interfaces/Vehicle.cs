using System;

namespace _3.Interfaces
{
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
}