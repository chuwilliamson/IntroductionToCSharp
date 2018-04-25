namespace _5.StatePattern
{
    public interface IState : IInfo
    {
        void OnEnter(IContext context);
        void UpdateState(IContext context);
        void OnExit(IContext context);
    }
}