using System.Collections.Generic;

namespace _6.CodeReview1
{
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
}