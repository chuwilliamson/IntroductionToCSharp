namespace _6.CodeReview1
{
    class NoProgram
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
}