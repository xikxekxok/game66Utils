using System;
using System.Linq;
using game66Utils.Catalog.Domain;
using game66Utils.Database;

namespace game66Utils.Catalog.DataLayer
{
    internal interface ICategoryRepository
    {
        void Add(Category category);
        ICategoryDomainQuery Query();
    }



    internal class CategoryRepository : ICategoryRepository
    {
        private MyDbContext _myDbContext;

        public CategoryRepository(MyDbContext context)
        {
            _myDbContext = context;
        }
        public void Add(Category category)
        {
            _myDbContext.u0120612_zeronicus_Categories.Add(category.State);
        }

        public ICategoryDomainQuery Query()
        {
            return new CategoryDomainQuery(_myDbContext);
        }

        private class CategoryDomainQuery : ICategoryDomainQuery
        {
            private IQueryable<u0120612_zeronicus_CategoryState> _query;

            public CategoryDomainQuery(MyDbContext context)
            {
                _query = context.u0120612_zeronicus_Categories.AsQueryable();
            }

            public ICategoryDomainQuery ById(Guid id)
            {
                var stringId = id.ToString();
                _query = _query.Where(x => x.Id == stringId);
                return this;
            }

            public Category FirstOrDefault()
            {
                return new Category(_query.FirstOrDefault());
            }
        }
    }

    internal interface ICategoryDomainQuery
    {
        ICategoryDomainQuery ById(Guid id);
        Category FirstOrDefault();
    }
}