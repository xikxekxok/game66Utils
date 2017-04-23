using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;
using NUnit.Framework;

namespace game66Utils.Tests.Catalog
{
    [TestFixture(Category = "unit")]
    public class CategoryTests
    {
        [Test]
        public void CreateCategoryTest()
        {
            var id = Guid.NewGuid();
            var name = "12345";
            var cat = new Category(id, name);
            Assert.AreEqual(id, cat.Id);
            Assert.AreEqual(name, cat.Name);
        }

        [Test]
        public void UpdateCategoryNameTest()
        {
            var id = Guid.NewGuid();
            var name = "12345";
            var name2 = "newName";

            var cat = new Category(id, name);
            cat.Update(name2);

            Assert.AreEqual(id, cat.Id);
            Assert.AreEqual(name2, cat.Name);
        }
    }
}
