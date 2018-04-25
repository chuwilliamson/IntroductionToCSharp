using System;

namespace _5.StatePattern
{
    public class GameRunningState : IState
    {
        public string Name => "GameRunning";

        public void OnEnter(IContext context)
        {
            Console.WriteLine("Entered GameRunning State");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("Exiting GameRunning State");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(new GameExitState());
        }
    }
}