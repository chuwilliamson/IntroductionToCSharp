namespace _4.Serialization.Base
{
    public class Dice : IRollable
    {
        public Dice(int sides){Value = sides;}
        public int Value { get; set; }
        public int Roll() => Globals.RandomSeed.Next(Value + 1);
    }
}