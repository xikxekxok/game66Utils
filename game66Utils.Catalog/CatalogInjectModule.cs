using game66Utils.Catalog.Command;
using game66Utils.Catalog.Command.Impl;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Query;
using Ninject.Modules;

namespace game66Utils.Catalog
{
    public class CatalogInjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryListQuery>().To<CategoryListQuery>().InSingletonScope();
            Bind<IAddCategoryCommand>().To<AddCategoryCommand>().InThreadScope();
            Bind<IUpdateCategoryCommand>().To<UpdateCategoryCommand>().InThreadScope();
            Bind<IUnitOfWorkFactory>().To<UnitOfWorkFactory>();
            Bind<IUnitOfWork>().To<UnitOfWork>();

        }
    }

}
