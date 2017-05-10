using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer;
using game66Utils.Infrastructure.DataLayer.EfImpl;
using Ninject;

namespace game66Utils.Stock.Dal
{
    class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IBaseUnitOfWork Create()
        {
            var storage = new DomainQueryStorage();
            storage.Register<IStockDomainQuery, StockDomainQuery>();
            return new BaseUnitOfWork<MyDbContext>(storage);
        }
    }
}