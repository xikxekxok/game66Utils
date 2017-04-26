using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Domain.Products;

namespace game66Utils.Catalog.Command.Impl
{
    internal class AddProductCommand : IAddProductCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;
        internal AddProductCommand(
            IUnitOfWorkFactory unitOfWorkFactory
        )
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }


        public void Execute(AddProductContext context)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                var product = new Product(context.BarCode, context.CategoryId, new ProductDescription(context.Title), new ProductPrice(context.PurchasePrice, context.SellingPrice));

                uof.CategoryRepository
            }
        }
    }
}
