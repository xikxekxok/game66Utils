using System;
using System.Data.Entity;
using System.Linq;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer.EfImpl;
using game66Utils.Stock.Domain;

namespace game66Utils.Stock.Dal
{
    class StockDomainQuery : BaseDomainQuery<CategoryStock, StockState>, IStockDomainQuery
    {
        protected override CategoryStock ToModel(StockState state)
        {
            return new CategoryStock(state);
        }

        protected override IQueryable<StockState> Include(IQueryable<StockState> query)
        {
            return query.Include(x=>x.ProductStocks);
        }

        public IStockDomainQuery ById(Guid id)
        {
            ApplyQuery(query=>query.Where(x=>x.CategoryId == id));
            return this;
        }
    }
}