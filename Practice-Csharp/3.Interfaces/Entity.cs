using System;
using System.Collections.Generic;

namespace _3.Interfaces
{
    public interface IDamageable
    {
        int ArmorClass { get; set; }
        bool TakeDamage(int amount);
    }
    public interface IDamager
    {
        int HitModifier { get; set; }
        void DoDamage(IDamageable damageable);
    }

    public abstract class Entity : IDamageable
    {
        private int health;
        private string name;

        public int ArmorClass { get; set; }

        public int Health { get; set; }

        public string Name { get; set; }

        public abstract bool TakeDamage(int amount);
    }

    public class Ninja : Entity, IDamager
    {
        public int AttackPower;
        private int hitModifier;
        public int HitModifier
        {
            get { return hitModifier; }

            set { hitModifier = value; }
        }

        public void DoDamage(IDamageable damageable)
        {
            var r = new Random();
            var roll = r.Next(1, 21);
            var result = 21 - (damageable.ArmorClass - hitModifier) / 20;
            Console.WriteLine(Name + " doing damage");
            damageable.TakeDamage(result);
        }

        public void Log()
        {
            Console.WriteLine(string.Format("Name = {0}, Health = {1}, AC = {2}", Name, Health, ArmorClass));
        }

        public override bool TakeDamage(int amount)
        {
            var newamount = Health - amount;
            if (newamount > 1)
                Health = newamount;
            Log();

            Console.WriteLine(Name + " Taking damage");

            return Health > 1;
        }
    }

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

    public class Combat
    {
        private List<IDamager> damagers;
        private List<IDamageable> damageables;
        
        private string quit;

        public void Start()
        {
            var Scorpion = new Ninja() { Name = "Scorpion", ArmorClass = 20, Health = 100, AttackPower = 50, HitModifier = 5 };
            var Subzero = new Ninja() { Name = "Sub Zero", ArmorClass = 20, Health = 100, AttackPower = 50, HitModifier = 5 };
            var Door = new Door() { Health = 100, Name = "Door" };
            damagers = new List<IDamager>() { Scorpion, Subzero };
            damageables = new List<IDamageable>() { Scorpion, Subzero, Door };

            while (quit != "Q" || quit != "q")
            {
                TurnStart();
                TurnEnd();
            }
        }
        void TurnStart()
        {
            var attacker = damagers[new Random().Next(0, damagers.Count)];
            var defender = damageables[new Random().Next(0, damageables.Count)];
            if (attacker == defender)
                TurnStart();
            else
            {
                attacker.DoDamage(defender);
            }
        }

        void TurnEnd()
        {
            Console.WriteLine(==="End of Turn===");
            Console.WriteLine("Next Turn? Q to Quit");
            quit = Console.ReadLine();
        }


    }
}
