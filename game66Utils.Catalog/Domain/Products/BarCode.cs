using System;

namespace game66Utils.Catalog.Domain.Products
{
    public class BarCode
    {
        public string Value { get; private set; }

        public BarCode(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Value = value;
        }

        protected bool Equals(BarCode other)
        {
            return string.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BarCode) obj);
        }

        public override int GetHashCode()
        {
            return (Value != null ? Value.GetHashCode() : 0);
        }
    }
}