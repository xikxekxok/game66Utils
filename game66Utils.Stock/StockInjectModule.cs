using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Stock.Command;
using game66Utils.Stock.Command.Impl;
using game66Utils.Stock.Dal;
using Ninject.Modules;

namespace game66Utils.Stock
{
    public class StockInjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWorkFactory>().To<UnitOfWorkFactory>();
            Bind<IStockDomainQuery>().To<StockDomainQuery>();
            Bind<IAddToStockCommand>().To<AddToStockCommand>();
            Bind<IRemoveFromStockCommand>().To<RemoveFromStockCommand>();
        }
    }
}
