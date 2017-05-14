using System;

namespace game66Utils.Catalog.Domain
{
    class CategoryId
    {
        public CategoryId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }

        protected bool Equals(CategoryId other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CategoryId) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}