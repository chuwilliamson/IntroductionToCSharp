namespace _4.Serialization
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