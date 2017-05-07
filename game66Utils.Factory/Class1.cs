using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog;
using game66Utils.Stock.Command;
using game66Utils.Stock.Command.Impl;
using Ninject;

namespace game66Utils.Factory
{
    public static class DiContainer
    {
        public static IKernel Kernel { get; private set; }

        public static void Register()
        {
            Kernel = new StandardKernel(new NinjectSettings
            {
                InjectNonPublic = true
            });
            Kernel.Load(new CatalogInjectModule());

            Kernel.Bind<IAddToStockCommand>().To<AddToStockCommand>();
            Kernel.Bind<IRemoveFromStock>().To<RemoveFromStock>();
        }
    }
}
