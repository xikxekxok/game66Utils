using System.Collections.Generic;

namespace game66Utils.Models
{
    public class PriceListModel
    {
        public List<PriceListItemModel> Items { get; set; }
    }

    public class PriceListItemModel
    {
        public ProductModel Product { get; set; }
        public PriceModel Price { get; set; }
    }
}