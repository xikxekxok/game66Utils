using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Stock.Dal
{
    public interface IUnitOfWorkFactory
    {
        IBaseUnitOfWork Create();
    }
}
