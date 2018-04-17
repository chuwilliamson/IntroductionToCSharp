using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.IntroToCsharp
{
    public abstract class Item
    {
        protected string Name { get; set; }
        protected int Id { get; set; }

        public List<Item> items;
    }
    public abstract class Weapon : Item
    {
        protected int Power { get; set; }
        public virtual void DoDamage(int amount) { }
    }
    public abstract class Potion : Item
    {
        protected int Power;
        public virtual void Consume() { }
    }

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
    public class Ether : Potion
    {
        //show autocomplete
    }
    public class Elixir : Potion
    {

    }



}
