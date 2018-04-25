namespace _4.Serialization.Abilities
{
    public interface IAbilities
    {
        IAbility Strength { get; }
        IAbility Dexterity { get; }
        IAbility Constitution { get; }
        IAbility Wisdom { get; }
        IAbility Intelligence { get; }
        IAbility Charisma { get; }
    }
}