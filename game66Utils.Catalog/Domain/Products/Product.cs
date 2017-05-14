using System;
using game66Utils.Database;
using game66Utils.Infrastructure;
using game66Utils.Infrastructure.DataLayer;
using JetBrains.Annotations;

namespace game66Utils.Catalog.Domain.Products
{
    class Product : IAggregate<ProductState>
    {
        public ProductState State { get; private set; }

        public Product([NotNull]CategoryId categoryId, [NotNull]ProductGroupId groupId, [NotNull]BarCode barCode, [NotNull]Price price)
        {
            categoryId.CheckNull(nameof(categoryId));
            groupId.CheckNull(nameof(groupId));
            barCode.CheckNull(nameof(barCode));
            price.CheckNull(nameof(price));

            State = new ProductState
            {
                Barcode = barCode.Value,
                PurchasePrice = price.Purchase,
                SellingPrice = price.Sale,
                CategoryId = categoryId.Value,
                ProductGroupId = groupId.Value
            };
        }

        public Product(ProductState state)
        {
            State = state;
        }

        public BarCode BarCode => new BarCode(State.Barcode);
        public ProductGroupId ProductGroupId => new ProductGroupId(State.ProductGroupId);
        public CategoryId CategoryId => new CategoryId(State.CategoryId);

        public Price Price
        {
            get { return new Price(State.PurchasePrice, State.SellingPrice); }
            set
            {
                State.PurchasePrice = value.Purchase;
                State.SellingPrice = value.Sale;
            }
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
            return Equals((Product)obj);
        }

        public override int GetHashCode()
        {
            return (BarCode != null ? BarCode.GetHashCode() : 0);
        }
    }
}
