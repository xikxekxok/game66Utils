using System;
using System.Globalization;
using game66Utils.Models;

namespace game66Utils.Services
{
    public interface IParseInputRowService
    {
        PriceListItemModel ParsePriceFromRow(FileRow row);

    }

    public class ParseInputRowService : IParseInputRowService
    {
        public PriceListItemModel ParsePriceFromRow(FileRow row)
        {
            if (string.IsNullOrEmpty(row.Id) || string.IsNullOrEmpty(row.Price))
                return null;

            var dString = row.Price.Replace(",", ".");

            decimal price;
            if (Decimal.TryParse(dString, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out price))
            {
                return new PriceListItemModel
                {
                    Product = new ProductModel
                    {
                        Id = row.Id
                    },
                    Price = new PriceModel
                    {
                        Price = price
                    }
                };
            }

            return null;
        }
    }
}