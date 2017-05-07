using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{
    internal interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
