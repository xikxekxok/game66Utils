using System.Collections.Generic;

namespace game66Utils.Models
{
    public class CompareInputMessage
    {
        public List<ProductModel> OldPriceList { get; set; }
        public List<ProductModel> NewPriceList { get; set; }
    }
}