using System.Collections.Generic;

namespace game66Utils.Models
{
    public class PriceListModel
    {
        public List<ProductModel> Products { get; set; }
        public PriceTypeEnum PriceType { get; set; }
    }
}