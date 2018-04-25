namespace _0.IntroToCsharp
{
    public abstract class Weapon : Item
    {
        protected int Power { get; set; }
        public virtual void DoDamage(int amount) { }
    }
}