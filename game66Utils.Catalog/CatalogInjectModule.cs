using game66Utils.Catalog.Command;
using game66Utils.Catalog.Command.AddGroup;
using game66Utils.Catalog.Command.AddProductToGroup;
using game66Utils.Catalog.Command.Impl;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.DataLayer.Impl;
using game66Utils.Catalog.Query;
using game66Utils.Catalog.Query.CategoryList;
using game66Utils.Catalog.Query.ProductExists;
using game66Utils.Catalog.Query.SimularGroup;
using Ninject.Modules;

namespace game66Utils.Catalog
{
    public class CatalogInjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryListQuery>().To<CategoryListQuery>().InSingletonScope();
            Bind<IProductExistsQuery>().To<ProductExistsQuery>();
            Bind<ISimularGroupQuery>().To<SimularGroupQuery>();
            
            Bind<IAddCategoryCommand>().To<AddCategoryCommand>().InThreadScope();
            Bind<IUpdateCategoryCommand>().To<UpdateCategoryCommand>().InThreadScope();

            Bind<IAddGroupCommand>().To<AddGroupCommand>().InThreadScope();
            Bind<IAddProductToGroupCommand>().To<AddProductToGroupCommand>().InThreadScope();


            Bind<IUnitOfWorkFactory>().To<UnitOfWorkFactory>();
        }
    }

}
