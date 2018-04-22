using System.Collections.Generic;
using System.Linq;

namespace _4.Serialization.src
{
    public static class CharacterCreator
    {
        public static int Roll4AddTop3
        {
            get
            {
                var val = new List<int>();
                for (int i = 0; i < 4; i++)
                    val.Add(new Dice(6).Roll());
                val.Sort();
                return val.Sum() - val[0];
            }
        }
    }
}
