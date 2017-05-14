using System;
using System.Data.Entity;
using System.Linq;
using game66Utils.Catalog.Domain;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer.EfImpl;

namespace game66Utils.Catalog.DataLayer.Impl
{
    class ProductGroupQuery : BaseDomainQuery<ProductGroup, ProductGroupState>, IProductGroupQuery
    {
        protected override ProductGroup ToModel(ProductGroupState state)
        {
            return new ProductGroup(state);
        }

        protected override IQueryable<ProductGroupState> Include(IQueryable<ProductGroupState> query)
        {
            return query.Include(x => x.Products);
        }

        public IProductGroupQuery ById(Guid productGroupId)
        {
            ApplyQuery(query=>query.Where(x=>x.Id == productGroupId));
            return this;
        }

        public IProductGroupQuery SimularName(string searchString)
        {
            ApplyQuery(query=>query.Where(x=>x.Title.Contains(searchString)));
            return this;
        }

        public IProductGroupQuery ByCategoryId(Guid categoryId)
        {
            ApplyQuery(query=>query.Where(x=>x.CategoryId == categoryId));
            return this;
        }
    }
}