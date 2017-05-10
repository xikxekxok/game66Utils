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
    public class StockTests
    {
        private Guid _defaultId = Guid.NewGuid();
        private string _defaultBarCode1 = "123456";
        private string _defaultBarCode2 = "654321";

        [Test]
        public void CreateStockTest()
        {
            var stock = new game66Utils.Stock.Domain.CategoryStock(_defaultId);
            Assert.AreEqual(_defaultId, stock.CategoryId);

            Assert.AreEqual(0, stock.UnitCount(_defaultBarCode1));
        }

        [Test]
        public void AddToStock_OneUnitInStock()
        {
            var stock = new game66Utils.Stock.Domain.CategoryStock(_defaultId);
            stock.AddUnit(_defaultBarCode1);

            Assert.AreEqual(1, stock.UnitCount(_defaultBarCode1));
            Assert.AreEqual(0, stock.UnitCount(_defaultBarCode2));
        }
        [Test]
        public void AddTwoToStock_OneUnitInStock()
        {
            var stock = new game66Utils.Stock.Domain.CategoryStock(_defaultId);
            stock.AddUnit(_defaultBarCode1);
            stock.AddUnit(_defaultBarCode1);

            Assert.AreEqual(2, stock.UnitCount(_defaultBarCode1));
            Assert.AreEqual(0, stock.UnitCount(_defaultBarCode2));
        }
        [Test]
        public void AddAndRemoveFromStock_NoUnitInStock()
        {
            var stock = new game66Utils.Stock.Domain.CategoryStock(_defaultId);
            stock.AddUnit(_defaultBarCode1);
            stock.RemoveUnit(_defaultBarCode1);

            Assert.AreEqual(0, stock.UnitCount(_defaultBarCode1));
            Assert.AreEqual(0, stock.UnitCount(_defaultBarCode2));
        }

        [Test]
        public void RemoveToStock_Throws()
        {
            var stock = new game66Utils.Stock.Domain.CategoryStock(_defaultId);
            Assert.Catch(()=>stock.RemoveUnit(_defaultBarCode1));
        }
    }

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
