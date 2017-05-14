using System;

namespace game66Utils.Catalog.Command.AddGroup
{
    public class AddGroupContext
    {
        public Guid CategoryId { get; set; }
        public Guid ProductGroupId { get; set; }
        public string Title { get; set; }
        public string BarCode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }

    }
}
