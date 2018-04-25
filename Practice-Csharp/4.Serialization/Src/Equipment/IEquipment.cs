using _4.Serialization.Abilities;
using _4.Serialization.Base;

namespace _4.Serialization.Equipment
{
    public interface IEquipment : ILogger
    {
        string Name { get; }
        int Cost { get; }
        int Weight { get; }
    }
}