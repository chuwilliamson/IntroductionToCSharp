using _4.Serialization.Interfaces;

namespace _4.Serialization.Base
{
    public class Dice : IRollable
    {
        public Dice(int sides)
        {
            Value = sides;
        }

        public int Value { get; set; }
        
        public int Roll()
        {
            return Globals.RandomSeed.Next(Value + 1);
        }
    }
}