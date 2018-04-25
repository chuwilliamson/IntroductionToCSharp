using System;


namespace _5.StatePattern
{
    public class GameStartState : IState
    {
        public string Name => "GameStart";

        public void OnEnter(IContext context)
        {
            Console.WriteLine("Entered GameStart State");
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("Exiting GameStart State");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(new GameRunningState());
        }
    }
}
