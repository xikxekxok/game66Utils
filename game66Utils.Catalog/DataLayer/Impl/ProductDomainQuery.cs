using System.Data.Entity;
using System.Linq;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer.EfImpl;

namespace game66Utils.Catalog.DataLayer.Impl
{
    class ProductDomainQuery : BaseDomainQuery<Product, ProductState>, IProductDomainQuery
    {

        protected override Product ToModel(ProductState state)
        {
            return new Product(state);
        }

        protected override IQueryable<ProductState> Include(IQueryable<ProductState> query)
        {
            return query;
        }

        public IProductDomainQuery ById(ProductId id)
        {
            ApplyQuery(query=>query.Where(x=>x.Barcode == id.BarCode && x.CategoryId == id.CategoryId));
            return this;
        }
    }
}