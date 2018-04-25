namespace _3.Interfaces
{
    public abstract class Entity : IDamageable
    {
        private int health;
        private string name;

        public int ArmorClass { get; set; }

        public int Health { get; set; }

        public string Name { get; set; }

        public abstract bool TakeDamage(int amount);
    }
}
