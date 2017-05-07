using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace game66Utils.Tests.Catalog
{
    [TestFixture(Category = "unit")]
    public class ProductTests
    {
        private string _defaultId = "defaultId";
        private Guid _defaultCategoryId = Guid.NewGuid();
        private ProductDescription _defaultDescription = new ProductDescription("DefaultTitle");

        private ProductPrice _defaultPrice = new ProductPrice(100,100);

        private Product CreateProduct()
        {
            return new Product(_defaultId, _defaultCategoryId, _defaultDescription, _defaultPrice);
        }

        [Test]
        public void CreateProductTest()
        {
            var product = CreateProduct();
            Assert.AreEqual(_defaultId, product.BarCode);
            Assert.AreEqual(_defaultCategoryId, product.CategoryId);
            Assert.AreEqual(_defaultDescription, product.Description);
            Assert.AreEqual(_defaultPrice, product.Price);
        }

        [Test]
        public void UpdatePriceTest()
        {
            var product = CreateProduct();

            var newPrice = new ProductPrice(200,200);
            product.UpdatePrice(newPrice);

            Assert.AreEqual(newPrice, product.Price);
        }

        [Test]
        public void UpdateDescriptionTest()
        {
            var product = CreateProduct();

            var newDescription = new ProductDescription("newTitle2");
            product.UpdateDescription(newDescription);

            Assert.AreEqual(newDescription, product.Description);
        }
    }
}
