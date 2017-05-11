namespace game66Utils.Catalog.Domain.Products
{
    public class Price
    {
        public decimal Purchase { get; private set; }
        public decimal Sale { get; private set; }

        public Price(decimal purchase, decimal sale)
        {
            Purchase = purchase;
            Sale = sale;
        }

        public bool Equals(Price other)
        {
            return Purchase == other.Purchase && Sale == other.Sale;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Price && Equals((Price) obj);
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