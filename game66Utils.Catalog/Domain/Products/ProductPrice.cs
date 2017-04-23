namespace game66Utils.Catalog.Domain.Products
{
    public class ProductPrice
    {
        public decimal Purchase { get; private set; }
        public decimal Sale { get; private set; }

        public ProductPrice(decimal purchase, decimal sale)
        {
            Purchase = purchase;
            Sale = sale;
        }

        public bool Equals(ProductPrice other)
        {
            return Purchase == other.Purchase && Sale == other.Sale;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ProductPrice && Equals((ProductPrice) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Purchase.GetHashCode() * 397) ^ Sale.GetHashCode();
            }
        }
    }
}