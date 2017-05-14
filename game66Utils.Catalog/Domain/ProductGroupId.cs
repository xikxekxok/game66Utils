using System;

namespace game66Utils.Catalog.Domain
{
    class ProductGroupId
    {
        public ProductGroupId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }

        protected bool Equals(ProductGroupId other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ProductGroupId) obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}