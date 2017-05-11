using System;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.Domain.Products
{
    class Product : IAggregate<ProductState>
    {
        public ProductState State { get; private set; }

        public Product(BarCode barCode, Price price)
        {
            State = new ProductState
            {
                Barcode = barCode.Value,
                PurchasePrice = price.Purchase,
                SellingPrice = price.Sale
            };
        }

        public Product(ProductState state)
        {
            State = state;
        }

        public BarCode BarCode => new BarCode(State.Barcode);
        public Price Price => new Price(State.PurchasePrice, State.SellingPrice);


        public void UpdatePrice(Price newPrice)
        {
            State.PurchasePrice = newPrice.Purchase;
            State.SellingPrice = newPrice.Sale;
        }

        protected bool Equals(Product other)
        {
            return Equals(BarCode, other.BarCode);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        public override int GetHashCode()
        {
            return (BarCode != null ? BarCode.GetHashCode() : 0);
        }
    }
}
