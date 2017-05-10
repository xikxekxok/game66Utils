using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Infrastructure.DataLayer;
using game66Utils.Stock.Domain;

namespace game66Utils.Stock.Dal
{
    interface IStockDomainQuery : IBaseDomainQuery<CategoryStock>
    {
        IStockDomainQuery ById(Guid id);
    }
}
