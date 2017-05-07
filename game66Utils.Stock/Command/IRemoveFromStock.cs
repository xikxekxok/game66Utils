using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;

namespace game66Utils.Stock.Command
{
    public interface IRemoveFromStock
    {
        Task Execute(ProductId productId);
    }
}