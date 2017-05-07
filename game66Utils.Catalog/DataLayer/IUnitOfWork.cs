using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{
    interface IUnitOfWork : IBaseUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}