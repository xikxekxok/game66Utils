using System;
using game66Utils.Catalog.Domain;
using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{
    internal interface ICategoryDomainQuery : IBaseDomainQuery<Category>
    {
        ICategoryDomainQuery ById(Guid id);
    }
}