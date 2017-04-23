using System;

namespace game66Utils.Catalog.Domain.Products
{
    public class ProductDescription
    {
        public string Title { get; }
        public ProductDescription(string title)
        {
            if (title == null) throw new ArgumentNullException(nameof(title));
            Title = title;
        }

        protected bool Equals(ProductDescription other)
        {
            return string.Equals(Title, other.Title);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ProductDescription) obj);
        }

        public override int GetHashCode()
        {
            return (Title != null ? Title.GetHashCode() : 0);
        }
    }
}