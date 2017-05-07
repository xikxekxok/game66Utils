using System;
using game66Utils.Database;

namespace game66Utils.Catalog.Domain.Products
{
    public class Product
    {
        internal ProductState State;

        public Product(string barCode, Guid categoryId, ProductDescription description, ProductPrice price)
        {
            State = new ProductState();
            State.Barcode = barCode;
            State.CategoryId = categoryId.ToString();
            State.Title = description.Title;
            State.PurchasePrice = price.Purchase;
            State.SellingPrice = price.Sale;
        }

        public Product(ProductState state)
        {
            State = state;
        }

        public ProductId Id => new ProductId(State.Barcode, CategoryId);
        public string BarCode => State.Barcode;
        public Guid CategoryId => Guid.Parse(State.CategoryId);
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
