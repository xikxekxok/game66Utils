using System;
using game66Utils.Catalog.Domain.Products;
using game66Utils.Database;
using game66Utils.Infrastructure;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.Domain
{
    class Category : IAggregate<CategoryState>
    {
        private CategoryState _state;
        public CategoryState State => _state;
        public Category(CategoryId id, string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            _state = new CategoryState();
            _state.Id = id.Value;
            _state.Name = name;
        }

        internal Category(CategoryState state)
        {
            _state = state;
        }
        
        public CategoryId Id => new CategoryId(_state.Id);
        public string Name => _state.Name;

        public void Update(string name)
        {
            _state.Name = name;
        }

        public ProductGroup CreateGroup(ProductGroupId id, Description description)
        {
            return new ProductGroup(id, this.Id, description);
        }
    }
}
