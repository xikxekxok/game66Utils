using System.Collections.Generic;

namespace game66Utils.Models
{
    public class CompareResultMessage
    {
        public List<ProductModel> NewProducts { get; set; }
        public List<ProductModel> DeletedProducts { get; set; }

        public List<ProductChangeModel> ChangedPrices { get; set; }

        public CompareResultMessage()
        {
            NewProducts = new List<ProductModel>();
            DeletedProducts = new List<ProductModel>();
            ChangedPrices = new List<ProductChangeModel>();
        }
    }
}