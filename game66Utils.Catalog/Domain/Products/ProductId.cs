using System;

namespace game66Utils.Catalog.Domain.Products
{
    public class ProductId
    {
        public string BarCode { get; private set; }
        public Guid CategoryId { get; private set; }

        public ProductId(string barCode, Guid categoryId)
        {
            if (barCode == null) throw new ArgumentNullException(nameof(barCode));
            BarCode = barCode;
            CategoryId = categoryId;
        }

        protected bool Equals(ProductId other)
        {
            return string.Equals(BarCode, other.BarCode, StringComparison.CurrentCultureIgnoreCase) 
                && CategoryId.Equals(other.CategoryId);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ProductId) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((BarCode?.GetHashCode() ?? 0) * 397) ^ CategoryId.GetHashCode();
            }
        }
    }
}