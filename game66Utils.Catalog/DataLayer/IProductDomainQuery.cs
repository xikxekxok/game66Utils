using System;
using game66Utils.Catalog.Domain;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Infrastructure;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.DataLayer
{
    internal interface IProductDomainQuery : IBaseDomainQuery<Product>
    {
        IProductDomainQuery ById(ProductId id);
    }
}