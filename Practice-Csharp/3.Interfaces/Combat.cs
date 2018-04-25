using System;
using System.Collections.Generic;

namespace _3.Interfaces
{
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
            Console.WriteLine("===End of Turn===");
            Console.WriteLine("Next Turn? Q to Quit");
            quit = Console.ReadLine();
        }


    }
}