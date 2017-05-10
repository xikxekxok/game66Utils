using System;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;

namespace game66Utils.Stock.Command
{
    public interface IRemoveFromStockCommand
    {
        Task Execute(Guid stockId, string productId);
    }
}