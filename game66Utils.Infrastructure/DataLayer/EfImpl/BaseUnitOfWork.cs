using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Ninject;

namespace game66Utils.Infrastructure.DataLayer.EfImpl
{
    public class DomainQueryStorage
    {
        private Dictionary<Type, Type> _container;

        public DomainQueryStorage()
        {
            _container = new Dictionary<Type, Type>();
        }
        public void Register<TInterface, TImplementation>() where TImplementation : class, IInitByContext, TInterface, new()
        {
            _container.Add(typeof(TInterface), typeof(TImplementation));
        }

        public T GetQuery<T>(DbContext context) where T : class
        {
            var typeImpl = _container[typeof(T)];
            var impl = Activator.CreateInstance(typeImpl);
            (impl as IInitByContext).Init(context);
            return impl as T;
        }
    }
    public class BaseUnitOfWork<TContext> : IBaseUnitOfWork where TContext : DbContext, new()
    {
        private DomainQueryStorage _domainQueryStorage;
        protected TContext Context { get; }

        public BaseUnitOfWork(DomainQueryStorage domainQueryStorage)
        {
            _domainQueryStorage = domainQueryStorage;
            Context = new TContext();
        }
        public void Dispose()
        {
            Context.Dispose();
        }

        public async Task Commit()
        {
            await Context.SaveChangesAsync();
        }

        public void Add<TState>(IAggregate<TState> newAggregate) where TState : class
        {
            Context.Set<TState>().Add(newAggregate.State);
        }

        public T Query<T>() where T : class
        {
            return _domainQueryStorage.GetQuery<T>(Context);
        }
    }
}