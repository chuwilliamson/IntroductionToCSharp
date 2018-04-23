using System;


namespace _4.Serialization
{
    public class Proficiency<T>
    {
        public T Target;
        public int Amount;
    }
    public class Proficiencies
    {
        public Type[] Armor { get; set; }
        public Type[] Weapons { get; set; }
        public Type[] Tools { get; set; }
        public Type[] SavingThrows { get; set; }
        public Type[] Skills { get; set; }
    }
}