using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Stock.Domain;
using NUnit.Framework;

namespace game66Utils.Tests.Stock
{
    [TestFixture(Category = "unit")]
    public class ProductStockTests
    {
        private ProductId _defaultId = new ProductId("12345", Guid.NewGuid());
        private ProductStock DefaultProduct()
        {
            return new ProductStock(_defaultId);
        }

        [Test]
        public void CreateProductTest()
        {
            var product = DefaultProduct();
            Assert.AreEqual(_defaultId, product.ProductId);
            Assert.AreEqual(0, product.CurrentQuantity);
        }

        [Test]
        public void AddToStock_OneQuantityReturn()
        {
            var product = DefaultProduct();

            product.AddToStock();

            Assert.AreEqual(1, product.CurrentQuantity);
        }

        [Test]
        public void RemoveFromStock_NewQuantityReturn()
        {
            var product = DefaultProduct();

            product.AddToStock();
            product.RemoveFromStock();

            Assert.AreEqual(0, product.CurrentQuantity);
        }

        [Test]
        public void EmptyStock_RemoveFromStock_Throws()
        {
            var product = DefaultProduct();

            Assert.Catch(() => product.RemoveFromStock());
        }
        
    }
}
