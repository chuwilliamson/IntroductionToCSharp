using System.Collections.Generic;

namespace _6.CodeReview1
{
    public class Warrior
    {
        public List<Stat> stats = new List<Stat>();
        public Warrior()
        {
            System.Random r = new System.Random();
            for (int i = 0; i < 8; i++)
                stats.Add(new Stat() {Value = r.Next(0, 25)});


        }
        
    }
}