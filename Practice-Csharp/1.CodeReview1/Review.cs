using System.Collections.Generic;
using _6.CodeReview1;

namespace MyCodeReview
{
    public class Review
    {
        public TextGroup TextGroup { get; set; }
        public Warrior warrior { get; set; }
        public string Runit()
        {
            warrior = new Warrior();
            TextGroup = new TextGroup(); 
            warrior.stats.ForEach(s => TextGroup.pairs.Add(new StatTextPair { stat = s, text = new Text() }));
            TextGroup.pairs.ForEach(p => p.text.text = p.stat.Value.ToString());
            return TextGroup.ToString();
        }
    }
}