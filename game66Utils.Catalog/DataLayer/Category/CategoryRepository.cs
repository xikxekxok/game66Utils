using System;
using System.Data.Entity;
using System.Linq;
using game66Utils.Catalog.Domain;
using game66Utils.Database;
using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{

    internal class CategoryRepository : ICategoryRepository
    {
        private MyDbContext _myDbContext;

        public CategoryRepository(MyDbContext context)
        {
            _myDbContext = context;
        }

        public void Add(Category category)
        {
            _myDbContext.Set<CategoryState>().Add(category.State);
            _myDbContext.Categories.Add(category.State);
        }

        public ICategoryDomainQuery Query()
        {
            return new CategoryDomainQuery(_myDbContext);
        }

        private class CategoryDomainQuery : BaseDomainQuery<Category, CategoryState>, ICategoryDomainQuery
        {
            public CategoryDomainQuery(MyDbContext context) : base(context)
            {
            }

            public ICategoryDomainQuery ById(Guid id)
            {
                var stringId = id.ToString();
                Query = Query.Where(x => x.Id == stringId);
                return this;
            }


            protected override IQueryable<CategoryState> CreateQuery(DbContext context)
            {
                return context.Set<CategoryState>().AsQueryable();
            }

            protected override Category ToModel(CategoryState state)
            {
                return new Category(state);
            }
        }
    }
}