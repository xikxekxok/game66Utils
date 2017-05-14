using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Stock.Domain
{
    public class CategoryStock : IAggregate<StockState>
    {
        public CategoryStock(Guid categoryId)
        {
            State = new StockState
            {
                CategoryId = categoryId,
                ProductStocks = new List<ProductStockState>()
            };
        }

        public CategoryStock(StockState state)
        {
            State = state;
        }
        public StockState State { get; }
        public Guid CategoryId => State.CategoryId;

        public int UnitCount(string productBarCode)
        {
            return GetProduct(productBarCode)?.Quantity ?? 0;
        }

        public void AddUnit(string productBarCode)
        {
            var product = GetProduct(productBarCode);
            if (product == null)
            {
                product = new ProductStockState
                {
                    BarCode = productBarCode,
                    CategoryId = CategoryId,
                    Quantity = 0,
                   
                };
                State.ProductStocks.Add(product);
            }
            product.Quantity = product.Quantity + 1;
        }

        public void RemoveUnit(string productBarCode)
        {
            var product = GetProduct(productBarCode);
            if (product == null || product.Quantity == 0)
                throw new Exception($"На складе нет единиц товара с штрихкодом {productBarCode}");

            product.Quantity = product.Quantity - 1;
        }

        private ProductStockState GetProduct(string productBarCode)
        {
            return
                State.ProductStocks.FirstOrDefault(
                    x => x.BarCode.Equals(productBarCode, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
