using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Infrastructure.DataLayer;
using JetBrains.Annotations;

namespace game66Utils.Catalog.Domain
{
    internal class ProductGroup : IAggregate<ProductGroupState>
    {
        public ProductGroupState State { get; }
        private readonly List<Product> _products;


        public ProductGroup(ProductGroupId id, CategoryId categoryId, [NotNull] Description description)
        {
            State = new ProductGroupState();
            State.Id = id.Value;
            State.CategoryId = categoryId.Value;

            if (description == null)
                throw new ArgumentNullException(nameof(description));

            State.Title = description.Title;
            State.Products = new List<ProductState>();
            _products = new List<Product>();
        }

        public ProductGroup(ProductGroupState state)
        {
            State = state;
            _products = state.Products.Select(x => new Product(x)).ToList();
        }

        public ProductGroupId Id => new ProductGroupId(State.Id);
        public CategoryId CategoryId => new CategoryId(State.CategoryId);

        public Description Description
        {
            get { return new Description(State.Title); }
            set { State.Title = value.Title; }
        }

        public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

        public void AddProduct([NotNull]BarCode barCode, [NotNull]Price price)
        {
            var product = new Product(CategoryId, Id, barCode, price);
            if (_products.Any(x => x.Equals(product)))
                throw new Exception($"Такой продукт уже есть в группе! {product.BarCode}");

            _products.Add(product);
            State.Products.Add(product.State);
        }

        #region equals
        protected bool Equals(ProductGroup other)
        {
            return Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ProductGroup)obj);
        }

        public override int GetHashCode()
        {
            return (Id.GetHashCode());
        }
        #endregion
    }
}
