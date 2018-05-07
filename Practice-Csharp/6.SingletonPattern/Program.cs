public class Singleton
{
    private static Singleton _instance;
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }
}







public class Player
{
    private Player() { }
    
    private static Player _instance;
    public static Player Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Player();
            return _instance;
        }
    }
    private int _health = 5;
    public int Health
    {
        get { return _health; }
    }

}







namespace _6.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int theplayershealth = Player.Instance.Health;

            System.Console.WriteLine(theplayershealth);
            System.Console.ReadLine();    
        }
    }
}
