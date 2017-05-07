using System.Collections.Generic;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using JetBrains.Annotations;

namespace game66Utils.Catalog.DataLayer
{
    internal interface ICategoryRepository
    {
        void Add(Category category);
        ICategoryDomainQuery Query();
    }
}