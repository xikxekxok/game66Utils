using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace game66Utils.Infrastructure
{
    public interface IAggregate<TState>
    {
        TState State { get; }
    }
    public interface IBaseDomainQuery<TDomain> where TDomain : class
    {
        Task<List<TDomain>> ToList();
        Task<TDomain> First();
        Task<bool> Any();
    }
    public abstract class BaseDomainQuery<TDomain, TState> : IBaseDomainQuery<TDomain> where TDomain : class
    {
        private IQueryable<TState> _query = null;
        private DbContext _myDbContext;

        protected IQueryable<TState> Query
        {
            get { return _query ?? (_query = CreateQuery(_myDbContext)); }
            set { _query = value; }
        }

        protected BaseDomainQuery(DbContext context)
        {
            _myDbContext = context;
        }

        protected abstract IQueryable<TState> CreateQuery(DbContext context);
        protected abstract TDomain ToModel(TState state);


        public async Task<List<TDomain>> ToList()
        {
            var list = await Query.ToListAsync();

            return list.Select(ToModel).ToList();
        }

        public async Task<bool> Any()
        {
            return await Query.AnyAsync();
        }

        [CanBeNull]
        public async Task<TDomain> First()
        {
            var state = await Query.FirstOrDefaultAsync();
            return state == null ? (TDomain)null : ToModel(state);
        }
    }
    public interface IBaseUnitOfWork : IDisposable
    {
        Task Commit();
    }
    public class BaseUnitOfWork<TContext> : IBaseUnitOfWork where TContext : DbContext, new()
    {
        protected TContext Context { get; }

        public BaseUnitOfWork()
        {
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
    }
}
