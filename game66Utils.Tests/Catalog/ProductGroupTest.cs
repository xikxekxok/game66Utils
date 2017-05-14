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
        private ProductGroupId _id = new ProductGroupId(Guid.NewGuid());
        private CategoryId _categoryId = new CategoryId(Guid.NewGuid());
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
            Assert.Catch(() => new ProductGroup(_id, _categoryId, null));
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
            group.AddProduct(new BarCode("12345"), new Price(50, 100));

            Assert.AreEqual(1, group.Products.Count);
            Assert.AreEqual(new BarCode("12345"), group.Products.FirstOrDefault().BarCode);
            Assert.AreEqual(new Price(50, 100), group.Products.FirstOrDefault().Price);
        }

        [Test]
        public void AddProduct_Duplicate_Throws()
        {
            var group = Create();

            group.AddProduct(new BarCode("12345"), new Price(50, 100));
            Assert.Catch(() => group.AddProduct(new BarCode("12345"), new Price(10, 10)));
        }

        [Test]
        public void AddProduct_NullBarCode_Throws()
        {
            var group = Create();
            Assert.Catch(() => group.AddProduct(null, new Price(10,10)));
        }
        [Test]
        public void AddProduct_NullPrice_Throws()
        {
            var group = Create();
            Assert.Catch(() => group.AddProduct(new BarCode("12345"), null));
        }
    }
}
