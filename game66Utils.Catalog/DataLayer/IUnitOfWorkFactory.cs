using System;
using System.Collections.Generic;
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
        Task Commit();
    }

    class UnitOfWork : IUnitOfWork
    {
        private MyDbContext _context;

        public UnitOfWork()
        {
            _context = new MyDbContext();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public ICategoryRepository CategoryRepository => new CategoryRepository(_context);
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }

    
}
