namespace _3.Interfaces
{
    public interface IDamageable
    {
        int ArmorClass { get; set; }
        bool TakeDamage(int amount);
    }
}