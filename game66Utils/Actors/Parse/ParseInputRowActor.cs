using System;
using System.Globalization;
using System.Threading.Tasks;
using game66Utils.Models;

namespace game66Utils.Actors.Parse
{
    public class ParseInputRowActor : OneTypeReceiveActor<FileRow, ProductModel>
    {
        protected override async Task<ProductModel> Handle(FileRow message)
        {
            if (string.IsNullOrEmpty(message.Id) || string.IsNullOrEmpty(message.Price))
                return null;

            var dString = message.Price.Replace(",", ".");

            decimal price;
            if (Decimal.TryParse(dString, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out price))
            {
                return new ProductModel
                {
                    Id = message.Id,
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
