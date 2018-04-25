namespace _5.StatePattern
{
    public interface IContext : IInfo
    {
        IState CurrentState { get; set; }
        void ChangeState(IState state);
        void UpdateContext();
    }
}