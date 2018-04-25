using System;

namespace _5.StatePattern
{
    public class ZyronState : IState
    {
        public string Name => "Zyron";

        public void OnEnter(IContext context)
        {
            Console.WriteLine("zyron state enter");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("zyron state exit");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(new GameStartState());
        }
    }
}