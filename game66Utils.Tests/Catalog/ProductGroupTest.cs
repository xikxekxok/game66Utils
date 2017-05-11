using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using game66Utils.Catalog.Domain.Products;
using NUnit.Framework;

namespace game66Utils.Tests.Catalog
{
    [TestFixture(Category = "unit")]
    public class ProductGroupTest
    {
        private Guid _id;
        private Guid _categoryId;
        private Description _description = new Description("abc");
        private ProductGroup Create()
        {
            return new ProductGroup(_id,_categoryId,_description);   
        }

        [Test]
        public void CreateGroupTest()
        {
            var group = Create();
            Assert.AreEqual(_id, group.Id);
            Assert.AreEqual(_categoryId, group.CategoryId);
            Assert.AreEqual(_description, group.Description);
            Assert.AreEqual(0, group.Products.Count);
        }


        [Test]
        public void CreateGroupTest_NullDescr_Throws()
        {
            Assert.Catch(() => new ProductGroup(_id, _categoryId, _description));
        }


        [Test]
        public void ChangeDescription()
        {
            var group = Create();
            var newDescr = new Description("42");
            group.Description = newDescr;
            Assert.AreEqual(newDescr, group.Description);
        }

        [Test]
        public void AddProduct()
        {
            var group = Create();
            var product = new Product(new BarCode("12345"), new Price(50, 100));

            group.AddProduct(product);

            Assert.AreEqual(product, group.GetProduct(new BarCode("12345")));

            Assert.AreEqual(1, group.Products.Count);
            Assert.AreEqual(product, group.Products.FirstOrDefault());
        }

        [Test]
        public void AddProduct_Duplicate_Throws()
        {
            var group = Create();
            var product = new Product(new BarCode("12345"), new Price(50, 100));
            var product2 = new Product(new BarCode("12345"), new Price(10,10));

            group.AddProduct(product);
            Assert.Catch(() => group.AddProduct(product2));
        }

        [Test]
        public void AddProduct_Null_Throws()
        {
            var group = Create();
            Assert.Catch(() => group.AddProduct(null));
        }

        [Test]
        public void GetProduct_Null_Throws()
        {
            var group = Create();
            var product = new Product(new BarCode("12345"), new Price(50, 100));
            group.AddProduct(product);

            Assert.Catch(() => group.GetProduct(null));
        }
    }
}
