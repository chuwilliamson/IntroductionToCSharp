using System;

namespace _3.Interfaces
{
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
}