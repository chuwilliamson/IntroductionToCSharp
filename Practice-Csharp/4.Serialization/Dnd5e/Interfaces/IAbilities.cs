using _4.Dnd5e.Abilities;

namespace _4.Dnd5e.Interfaces
{
    public interface IAbilities
    {
        Ability STR { get; }
        Ability DEX { get; }
        Ability CON { get; }
        Ability WIS { get; }
        Ability INT { get; }
        Ability CHR { get; }
    }
}