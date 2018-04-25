using System;

namespace _3.Interfaces
{
    public class Door : Entity, ILoggable
    {
        public override bool TakeDamage(int amount)
        {
            Console.WriteLine(Name + " Taking damage");
            Log();
            return Health > 1;
        }
        public void Log()
        {
            Console.WriteLine(string.Format("Name = {0}, Health = {1}, AC = {2}", Name, Health, ArmorClass));
        }

    }
}