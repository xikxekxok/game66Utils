using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using JetBrains.Annotations;

namespace game66Utils.Catalog.Domain
{
    internal class ProductGroup
    {
        public ProductGroup(Guid id, Guid categoryId, [NotNull] Description description)
        {
            Id = id;
            CategoryId = categoryId;

            if (description == null)
                throw new ArgumentNullException(nameof(description));
            Description = description;
            Products = new List<Product>();
        }

        public Guid Id { get; }
        public Guid CategoryId { get; }
        public Description Description { get; set; }

        public List<Product> Products { get; }
        public void AddProduct([NotNull] Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            if (Products.Any(x=>x.Equals(product)))
                throw new Exception($"Такой продукт уже есть в группе! {product.BarCode}");

            Products.Add(product);
        }

        public Product GetProduct(BarCode barCode)
        {
            if (barCode == null)
                throw new ArgumentNullException(nameof(barCode));
            return Products.FirstOrDefault(x => x.BarCode.Equals(barCode));
        }
    }
}
