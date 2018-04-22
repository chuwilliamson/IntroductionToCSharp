
namespace _4.Serialization
{
    public class Ability : IAbility
    {
        public int Score { get; set; }
        public int Modifier => (Score - 10) / 2;
    }
}
