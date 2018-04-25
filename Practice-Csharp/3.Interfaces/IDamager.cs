namespace _3.Interfaces
{
    public interface IDamager
    {
        int HitModifier { get; set; }
        void DoDamage(IDamageable damageable);
    }
}