using System;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.Domain.Products
{
    class Product : IAggregate<ProductState>
    {
        public ProductState State { get; private set; }

        public Product(string barCode, Guid categoryId, ProductDescription description, ProductPrice price)
        {
            State = new ProductState
            {
                Barcode = barCode,
                CategoryId = categoryId,
                Title = description.Title,
                PurchasePrice = price.Purchase,
                SellingPrice = price.Sale
            };
        }

        public Product(ProductState state)
        {
            State = state;
        }

        public ProductId Id => new ProductId(State.Barcode, CategoryId);
        public string BarCode => State.Barcode;
        public Guid CategoryId => State.CategoryId;
        public ProductDescription Description => new ProductDescription(State.Title);
        public ProductPrice Price => new ProductPrice(State.PurchasePrice, State.SellingPrice);


        public void UpdatePrice(ProductPrice newPrice)
        {
            State.PurchasePrice = newPrice.Purchase;
            State.SellingPrice = newPrice.Sale;
        }

        public void UpdateDescription(ProductDescription newDescription)
        {
            State.Title = newDescription.Title;
        }
    }
}
