using System;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Domain;
using game66Utils.Catalog.Domain.Products;

namespace game66Utils.Catalog.Command.AddProductToGroup
{
    public interface IAddProductToGroupCommand
    {
        Task Execute(AddProductToGroupContext context);
    }

    class AddProductToGroupCommand : IAddProductToGroupCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public AddProductToGroupCommand(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        public async Task Execute(AddProductToGroupContext context)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                ProductGroup productGroup = await uof.Query<IProductGroupQuery>().ById(context.ProductGroupId).First();
                if (productGroup == null)
                    throw new Exception($"productGroup with id {context.ProductGroupId} not found!");

                productGroup.AddProduct(new BarCode(context.BarCode), new Price(context.PurchasePrice, context.SellingPrice));

                await uof.Commit();
            }
        }
    }
}