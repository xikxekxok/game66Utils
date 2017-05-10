using System;
using System.Linq;
using game66Utils.Catalog.Domain;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer.EfImpl;

namespace game66Utils.Catalog.DataLayer.Impl
{
    class CategoryDomainQuery : BaseDomainQuery<Category, CategoryState>, ICategoryDomainQuery
    {
        public ICategoryDomainQuery ById(Guid id)
        {
            ApplyQuery(query=>query.Where(x=>x.Id == id));
            return this;
        }

        protected override Category ToModel(CategoryState state)
        {
            return new Category(state);
        }

        protected override IQueryable<CategoryState> Include(IQueryable<CategoryState> query)
        {
            return query;
        }
    }
}