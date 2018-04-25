namespace _4.Serialization.Equipment
{
    public abstract class Equipment : IEquipment
    {
        public virtual string Name => GetType().Name;
        public abstract int Cost { get; }
        public abstract int Weight { get; }

        public virtual string Info => string.Format("Name: {0} Cost: {1} Weight: {2}", Name, Cost, Weight);
        public void Log()
        {
            throw new System.NotImplementedException();
        }
    }
}