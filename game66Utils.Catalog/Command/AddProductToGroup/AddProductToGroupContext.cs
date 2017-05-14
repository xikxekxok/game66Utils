using System;

namespace game66Utils.Catalog.Command.AddProductToGroup
{
    public class AddProductToGroupContext
    {
        public Guid ProductGroupId { get; set; }
        public string BarCode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
    }
}