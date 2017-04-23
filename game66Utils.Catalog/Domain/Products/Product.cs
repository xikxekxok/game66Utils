using System;
using game66Utils.Database;

namespace game66Utils.Catalog.Domain.Products
{
    public class Product
    {
        private u0120612_zeronicus_ProductState _state;

        public Product(string barCode, Guid categoryId, ProductDescription description, ProductPrice price)
        {
            _state.Barcode = barCode;
            _state.CategoryId = categoryId.ToString();
            _state.Title = Description.Title;
            _state.PurchasePrice = price.Purchase;
            _state.SellingPrice = price.Sale;
        }

        public Product(u0120612_zeronicus_ProductState state)
        {
            _state = state;
        }

        public string Id => _state.Barcode;
        public Guid CategoryId => Guid.Parse(_state.CategoryId);
        public ProductDescription Description => new ProductDescription(_state.Title);
        public ProductPrice Price => new ProductPrice(_state.PurchasePrice, _state.SellingPrice);

        public void UpdatePrice(ProductPrice newPrice)
        {
            _state.PurchasePrice = newPrice.Purchase;
            _state.SellingPrice = newPrice.Sale;
        }

        public void UpdateDescription(ProductDescription newDescription)
        {
            _state.Title = Description.Title;
        }
    }
}
