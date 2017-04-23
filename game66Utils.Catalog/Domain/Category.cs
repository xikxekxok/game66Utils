using System;
using game66Utils.Database;

namespace game66Utils.Catalog.Domain
{
    public class Category
    {
        internal u0120612_zeronicus_CategoryState State { get; set; }

        public Category(Guid id, string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            State = new u0120612_zeronicus_CategoryState();
            State.Id = id.ToString();
            State.Name = name;
        }

        internal Category(u0120612_zeronicus_CategoryState state)
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
