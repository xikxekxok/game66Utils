using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Models;

namespace game66Utils.Services
{
    public interface IComparePriceTableService
    {
        CompareResult CompareTables(PriceListModel oldPrice, PriceListModel newPrice);
    }

    public class ComparePriceTableService : IComparePriceTableService
    {
        public CompareResult CompareTables(PriceListModel oldPrice, PriceListModel newPrice)
        {
            var items = oldPrice.Items.FullOuterJoin(newPrice.Items, x => x.Product.Id, x => x.Product.Id,
                (row, priceRow, id) => new CompareResultItem
                {
                    OldPrice = row,
                    NewPrice = priceRow
                },
                null, null, StringComparer.InvariantCultureIgnoreCase);

            return new CompareResult(items);
        }
    }
}
