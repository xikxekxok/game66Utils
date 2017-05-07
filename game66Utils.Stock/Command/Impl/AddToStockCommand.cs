using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Stock.Domain;

namespace game66Utils.Stock.Command.Impl
{
    public class AddToStockCommand : IAddToStockCommand
    {
        public AddToStockCommand()
        {
            
        }
        public async Task Execute(ProductId productId)
        {
            using (var context = new MyDbContext())
            {
                var state =
                    context.ProductStocks.FirstOrDefault(
                        x => x.BarCode == productId.BarCode && x.CategoryId == productId.CategoryId);

                ProductStock stock;
                if (state == null)
                {
                    stock = new ProductStock(productId);
                    context.ProductStocks.Add(stock.State);
                }
                else
                {
                    stock = new ProductStock(state);
                }

                stock.AddToStock();

                await context.SaveChangesAsync();
            }
        }
    }

    public class RemoveFromStock : IRemoveFromStock
    {
        public async Task Execute(ProductId productId)
        {
            using (var context = new MyDbContext())
            {
                var state =
                    context.ProductStocks.FirstOrDefault(
                        x => x.BarCode == productId.BarCode && x.CategoryId == productId.CategoryId);

                if (state == null)
                    throw new Exception("Product not found!");
                ProductStock stock = new ProductStock(state);

                stock.RemoveFromStock();

                await context.SaveChangesAsync();
            }
        }
    }
}
