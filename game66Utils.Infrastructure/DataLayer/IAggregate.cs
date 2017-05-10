namespace game66Utils.Infrastructure.DataLayer
{
    public interface IAggregate<out TState> where TState : class
    {
        TState State { get; }
    }
}