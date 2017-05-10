using System;
using game66Utils.Catalog.Domain;
using game66Utils.Infrastructure;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.DataLayer
{
    internal interface ICategoryDomainQuery : IBaseDomainQuery<Category>
    {
        ICategoryDomainQuery ById(Guid id);
    }
}