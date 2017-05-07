using game66Utils.Database;
using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{
    class UnitOfWork : BaseUnitOfWork<MyDbContext>, IUnitOfWork
    {
        public ICategoryRepository CategoryRepository => new CategoryRepository(Context);
        public IProductRepository ProductRepository { get; }

    }
}