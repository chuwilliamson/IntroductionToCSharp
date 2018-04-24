 
namespace _5.StatePattern
{
    public interface IInfo
    {
        string Name { get; }
    }

    public interface IState : IInfo
    {
        void OnEnter(IContext context);
        void UpdateState(IContext context);
        void OnExit(IContext context);
    }

    public interface IContext : IInfo
    {
        IState CurrentState { get; set; }
        void ChangeState(IState state);
        void UpdateContext();
    }
   
    public class GameContext : IContext
    {         
        public string Name => "GameContext";

        public int TurnCount { get; set; }

        public IState CurrentState { get; set; }

        public void ChangeState(IState state)
        {
            CurrentState.OnExit(this);
            CurrentState = state;
            CurrentState.OnEnter(this);
            TurnCount++;
        }

        /// <summary>
        /// this should be called from outside of the class by the user
        /// </summary>
        public void UpdateContext()
        {
            CurrentState.UpdateState(this);
        }
    }
   
}
