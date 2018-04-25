using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _0.IntroToCsharp
{
    public abstract class Item
    {
        protected string Name { get; set; }
        protected int Id { get; set; }

        public List<Item> items;
    }
}
