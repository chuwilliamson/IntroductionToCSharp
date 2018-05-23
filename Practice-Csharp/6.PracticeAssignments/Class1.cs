using System.Collections.Generic;


namespace _6.PracticeAssignments
{
    ///Code Review 1
    /// You have 90 minutes to complete this assignment
    ///this is bad, make it not bad
    ///provide a solution and useful review for this code.
    ///Scenario: you are a mid level software engineer tasked with mentoring an intern
    ///YOU setup the structures for him to use, Stat, Warrior
    ///He is attempting to populate text for his user interface application
    ///you walk by his desk and see that he is about to commit 
    ///the following code
    ///================begin pile of shit=================
    /// 
    public class StatTextPair
    {
        public Stat stat;
        public Text text;
        public override string ToString()
        {
            return string.Format("statName:{0} statValue: {1} textValue{2}", stat, stat.Value, text.text);
        }
    }

    public class TextGroup//creating this object will ensure the Text objects are instantiated
    {
        public List<StatTextPair> pairs = new List<StatTextPair>();
        public override string ToString()
        {
            var result = string.Empty;
            pairs.ForEach(p => result += p.ToString() + '\n');
            return result;
        }
    }

    public class Review
    {
        public TextGroup TextGroup { get; set; }
        public Warrior warrior { get; set; }
        public string Runit()
        {
            warrior.stats = new List<Stat>();
            warrior.stats.ForEach(s => TextGroup.pairs.Add(new StatTextPair { stat = s, text = new Text() }));
            TextGroup.pairs.ForEach(p => p.text.text = p.stat.Value.ToString());
            return TextGroup.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            //you are declaring these objects so i'm assuming you are intending to make new Text Objects
            //IF that is the case then you will need a 1:1 relationship of a textobject to a stat object related to the Warrior object
            Text text1 = new Text(), text2 = new Text(), text3 = new Text();
            Warrior warrior = new Warrior();
            text1.text = warrior.stats[0].Value.ToString();//you are counting
            text2.text = warrior.stats[1].Value.ToString();
            text3.text = warrior.stats[2].Value.ToString();
            //these values are overwriting each other if you are trying to display unique stats you must have different textbox groups ex: Text text4, text5, text6; and Text text7 text8 text9
            text1.text = warrior.stats[3].Value.ToString();
            text2.text = warrior.stats[4].Value.ToString();
            text3.text = warrior.stats[5].Value.ToString();

            text1.text = warrior.stats[6].Value.ToString();
            text2.text = warrior.stats[7].Value.ToString();
            text3.text = warrior.stats[8].Value.ToString();
        }
    }
    ///=============end pile of shit===================

    /*Provide the solution and feedback required to make him NEVER EVER DO THIS AGIN'*/

    ///==============begin you wrote this================
    public class Text
    {
        public string text;
    }

    public class Stat
    {
        public int Value;
    }

    public class Warrior
    {
        public List<Stat> stats;
    }
    ///=============end you wrote this======================///
}
