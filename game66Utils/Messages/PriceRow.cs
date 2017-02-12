using System.Collections.Generic;

namespace game66Utils.Messages
{
    public class PriceRow
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
    }

    public class PriceListModel
    {
        public List<PriceRow> Price { get; set; }
        public FileTypeEnum FileType { get; set; }
    }
}