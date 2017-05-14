using System;
using System.Threading.Tasks;

namespace game66Utils.Infrastructure.DataLayer
{
    public interface IBaseUnitOfWork : IDisposable
    {
        void Add<TState>(IAggregate<TState> newAggregate) where TState : class;
        Task Commit();
        T Query<T>(bool readOnly = false) where T : class;
    }
}