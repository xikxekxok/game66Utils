using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer;
using game66Utils.Infrastructure.DataLayer.EfImpl;
using Ninject;

namespace game66Utils.Catalog.DataLayer.Impl
{
    class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IBaseUnitOfWork Create()
        {
            var storage = new DomainQueryStorage();
            storage.Register<ICategoryDomainQuery, CategoryDomainQuery>();
            storage.Register<IProductGroupQuery, ProductGroupQuery>();
            return new BaseUnitOfWork<MyDbContext>(storage);
        }
    }
}