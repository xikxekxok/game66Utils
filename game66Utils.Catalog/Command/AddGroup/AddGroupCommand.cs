using System;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Domain;
using game66Utils.Catalog.Domain.Products;

namespace game66Utils.Catalog.Command.AddGroup
{
    class AddGroupCommand : IAddGroupCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public AddGroupCommand(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        public async Task Execute(AddGroupContext context)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                Category category = await uof.Query<ICategoryDomainQuery>(true).ById(context.CategoryId).First();

                if (category == null)
                    throw new Exception($"category with id {context.CategoryId} not found");

                if (await uof.Query<IProductGroupQuery>(true).ById(context.ProductGroupId).Any())
                {
                    throw new Exception($"product group with id {context.ProductGroupId} already exists!");
                }

                var productGroup = category.CreateGroup(new ProductGroupId(context.ProductGroupId), new Description(context.Title));
                uof.Add(productGroup);

                productGroup.AddProduct(new BarCode(context.BarCode), new Price(context.PurchasePrice, context.SellingPrice));

                await uof.Commit();
            }
        }
    }
}