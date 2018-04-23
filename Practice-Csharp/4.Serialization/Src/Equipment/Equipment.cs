using _4.Serialization.Interfaces;

namespace _4.Serialization.Equipment
{
    public abstract class Equipment : IEquipment
    {
        public abstract string Name { get; }
        public abstract int Cost { get; }
        public abstract int Weight { get; }
    }
}