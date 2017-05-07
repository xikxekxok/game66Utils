using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;

namespace game66Utils.Stock.Domain
{
    public class ProductStock
    {
        public ProductStock(
            ProductId productId
            )
        {
            State = new ProductStockState();
            State.BarCode = productId.BarCode;
            State.CategoryId = productId.CategoryId;
            State.Quantity = 0;
            //State.ProductStockEvents = new List<ProductStockEventState>();
        }

        public ProductStock(ProductStockState stockState)
        {
            State = stockState;
        }

        public ProductId ProductId => new ProductId(State.BarCode, State.CategoryId);
        public int CurrentQuantity => State.Quantity;

        public void AddToStock()
        {
            State.Quantity++;
            //State.ProductStockEvents.Add(new ProductStockEventState
            //{
            //    BarCode = State.BarCode,
            //    CategoryId = State.CategoryId,
            //    ChangeQuantity = 1,
            //    DateExecute = DateTime.Now
            //});
        }

        public void RemoveFromStock()
        {
            if (State.Quantity == 0)
                throw new Exception("Склад пуст, с него нельзя удалить товар!");
            State.Quantity--;
            //State.ProductStockEvents.Add(new ProductStockEventState
            //{
            //    BarCode = State.BarCode,
            //    CategoryId = State.CategoryId,
            //    ChangeQuantity = -1,
            //    DateExecute = DateTime.Now
            //});
        }
        public ProductStockState State;
    }
}
