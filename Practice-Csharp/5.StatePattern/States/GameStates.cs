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
