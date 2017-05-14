using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using game66Utils.Catalog.Domain.Products;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace game66Utils.Tests.Catalog
{
    [TestFixture(Category = "unit")]
    public class ProductTests
    {
        private BarCode _defaultId = new BarCode("defaultId");
        private CategoryId _defaultCategoryId = new CategoryId(Guid.NewGuid());
        private ProductGroupId _defaultProductGroupId = new ProductGroupId(Guid.NewGuid());
        private Description _defaultDescription = new Description("DefaultTitle");

        private Price _defaultPrice = new Price(100,100);

        private Product CreateProduct()
        {
            return new Product(_defaultCategoryId, _defaultProductGroupId, _defaultId, _defaultPrice);
        }

        [Test]
        public void CreateProductTest()
        {
            var product = CreateProduct();
            Assert.AreEqual(_defaultId, product.BarCode);
            Assert.AreEqual(_defaultPrice, product.Price);
            Assert.AreEqual(_defaultProductGroupId, product.ProductGroupId);
            Assert.AreEqual(_defaultCategoryId, product.CategoryId);
        }

        [Test]
        public void UpdatePriceTest()
        {
            var product = CreateProduct();

            var newPrice = new Price(200,200);
            product.Price = newPrice;

            Assert.AreEqual(newPrice, product.Price);
        }
    }
}
