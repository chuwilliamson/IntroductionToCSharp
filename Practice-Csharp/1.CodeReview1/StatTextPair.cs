namespace _6.CodeReview1
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
        public Stat stat = new Stat();
        public Text text = new Text();
        public override string ToString()
        {
            return string.Format("statName:{0} statValue: {1} TextValue: {2}", stat.GetType().Name, stat.Value, text.text);
        }
    }
}