using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using game66Utils.Database;
using JetBrains.Annotations;

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
            _myDbContext.Set<u0120612_zeronicus_CategoryState>().Add(category.State);
            _myDbContext.u0120612_zeronicus_Categories.Add(category.State);
        }

        public ICategoryDomainQuery Query()
        {
            return new CategoryDomainQuery(_myDbContext);
        }

        private class CategoryDomainQuery : BaseDomainQuery<Category, u0120612_zeronicus_CategoryState>, ICategoryDomainQuery
        {
            //private IQueryable<u0120612_zeronicus_CategoryState> _query;

            public CategoryDomainQuery(MyDbContext context) : base(context)
            {
                //_query = context.u0120612_zeronicus_Categories.AsQueryable();
            }

            public ICategoryDomainQuery ById(Guid id)
            {
                var stringId = id.ToString();
                Query = Query.Where(x => x.Id == stringId);
                return this;
            }


            protected override IQueryable<u0120612_zeronicus_CategoryState> CreateQuery(DbContext context)
            {
                return context.Set<u0120612_zeronicus_CategoryState>().AsQueryable();
            }

            protected override Category ToModel(u0120612_zeronicus_CategoryState state)
            {
                return new Category(state);
            }
        }
    }

    public interface IBaseDomainQuery<TDomain> where TDomain : class
    {
        Task<List<TDomain>> ToList();
        Task<TDomain> First();
        Task<bool> Any();
    }
    public abstract class BaseDomainQuery<TDomain, TState> : IBaseDomainQuery<TDomain> where TDomain : class
    {
        private IQueryable<TState> _query = null;
        private DbContext _myDbContext;

        protected IQueryable<TState> Query
        {
            get { return _query ?? (_query = CreateQuery(_myDbContext)); }
            set { _query = value; }
        }

        protected BaseDomainQuery(DbContext context)
        {
            _myDbContext = context;
        }

        protected abstract IQueryable<TState> CreateQuery(DbContext context);
        protected abstract TDomain ToModel(TState state);


        public async Task<List<TDomain>> ToList()
        {
            var list = await Query.ToListAsync();

            return list.Select(ToModel).ToList();
        }

        public async Task<bool> Any()
        {
            return await Query.AnyAsync();
        }

        [CanBeNull]
        public async Task<TDomain> First()
        {
            var state = await Query.FirstOrDefaultAsync();
            return state == null ? (TDomain)null : ToModel(state);
        }
    }

    internal interface ICategoryDomainQuery : IBaseDomainQuery<Category>
    {
        ICategoryDomainQuery ById(Guid id);
    }
}