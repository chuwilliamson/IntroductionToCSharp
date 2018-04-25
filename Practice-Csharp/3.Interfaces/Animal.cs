using System;

namespace _3.Interfaces
{
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
}