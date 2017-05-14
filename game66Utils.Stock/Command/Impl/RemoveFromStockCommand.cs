using System;
using System.Threading.Tasks;
using game66Utils.Stock.Dal;

namespace game66Utils.Stock.Command.Impl
{
    public class RemoveFromStockCommand : IRemoveFromStockCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public RemoveFromStockCommand(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Execute(Guid stockId, string productId)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                var stock = await uof.Query<IStockDomainQuery>().ById(stockId).First();

                if (stock == null)
                    throw new Exception("На складе нет единиц товара с таким идентификатором");

                stock.RemoveUnit(productId);

                await uof.Commit();
            }
        }
    }
}