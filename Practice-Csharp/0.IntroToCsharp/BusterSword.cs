using System;

namespace _0.IntroToCsharp
{
    public class BusterSword : Weapon
    {
        public int Attack
        {
            get { return this.Power; }
            set
            {   
                Console.WriteLine("Changed Power");
                this.Power = value;
            }
        }
        public void Swing() { }
      
    }
}