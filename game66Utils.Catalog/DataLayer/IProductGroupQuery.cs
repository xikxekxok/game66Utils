using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.DataLayer
{
    interface IProductGroupQuery : IBaseDomainQuery<ProductGroup>
    {
        IProductGroupQuery ById(Guid productGroupId);
        IProductGroupQuery ByCategoryId(Guid categoryId);
        IProductGroupQuery SimularName(string searchString);
    }
}
