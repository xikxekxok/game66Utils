using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using game66Utils.Database;

namespace game66Utils.Catalog.DataLayer
{
    internal interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }

    class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new UnitOfWork();
        }
    }

    internal interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        Task Commit();
    }

    class UnitOfWork : BaseUnitOfWork<MyDbContext>, IUnitOfWork
    {
        public ICategoryRepository CategoryRepository => new CategoryRepository(Context);
        public IProductRepository ProductRepository { get; }

        public async Task Commit()
        {
            await Context.SaveChangesAsync();
        }
    }

    public class BaseUnitOfWork<TContext> where TContext : DbContext, new()
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
    }
}
