 
namespace _5.StatePattern
{
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
