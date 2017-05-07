using System;
using game66Utils.Database;
using game66Utils.Infrastructure;

namespace game66Utils.Catalog.Domain
{
    public class Category : IAggregate<CategoryState>
    {
        public CategoryState State { get; set; }

        public Category(Guid id, string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            State = new CategoryState();
            State.Id = id.ToString();
            State.Name = name;
        }

        internal Category(CategoryState state)
        {
            State = state;
        }

        //TODO проверку на корректность инварианта в БД
        public Guid Id => Guid.Parse(State.Id);
        public string Name => State.Name;

        public void Update(string name)
        {
            State.Name = name;
        }
    }
}
