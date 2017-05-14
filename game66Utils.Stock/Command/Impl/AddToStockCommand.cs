using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Stock.Dal;
using game66Utils.Stock.Domain;

namespace game66Utils.Stock.Command.Impl
{
    public class AddToStockCommand : IAddToStockCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public AddToStockCommand(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        

        public async Task Execute(Guid categoryId, string productUnitBarCode)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                CategoryStock stock = await uof.Query<IStockDomainQuery>().ById(categoryId).First();

                if (stock == null)
                {
                    stock = new CategoryStock(categoryId);
                    uof.Add(stock);
                }

                stock.AddUnit(productUnitBarCode);

                await uof.Commit();
            }
        }
    }
}
