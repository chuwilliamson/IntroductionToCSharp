using System;

namespace _0.IntroToCsharp
{
    public class GatlingGun : Weapon
    {
        //show autocomplete
        public override void DoDamage(int amount)
        {
            base.DoDamage(amount);
            Console.WriteLine("rata tat tat tat");
        }

        public override string ToString()
        {
            return "it a gun";
        }
        public void Shoot() { }
    }
}