using System;

namespace _5.StatePattern
{
    public class GameExitState : IState
    {
        public string Name => "GameExit";

        public void OnEnter(IContext context)
        {
            Console.WriteLine("Entered GameExit State");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("Exiting GameExit State");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(new ZyronState());
        }
    }
}