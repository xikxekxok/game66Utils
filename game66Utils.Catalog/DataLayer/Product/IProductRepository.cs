using System;
using game66Utils.Catalog.Domain;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{
    internal interface IProductRepository
    {
        void Add(Product product);
        IProductDomainQuery Query();
    }

    class ProductRepository : IProductRepository
    { 
    private MyDbContext _myDbContext;

    public ProductRepository(MyDbContext context)
    {
        _myDbContext = context;
    }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IProductDomainQuery Query()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IProductDomainQuery : IBaseDomainQuery<Product>
    {
        IProductDomainQuery ById(ProductId id);
        IProductDomainQuery ById(string barCode, Guid categoryId);

    }
}