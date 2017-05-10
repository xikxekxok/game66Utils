using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;

namespace game66Utils.Stock.Command
{
    public interface IAddToStockCommand
    {
        Task Execute(Guid categoryId, string productUnitBarCode);
    }
}
