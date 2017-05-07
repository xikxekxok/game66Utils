using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game66Utils.Catalog.Command
{
    public interface IAddProductCommand
    {
        Task Execute(AddProductContext context);
    }

    public class AddProductContext
    {
        public string BarCode { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; }

        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }

    }
}
