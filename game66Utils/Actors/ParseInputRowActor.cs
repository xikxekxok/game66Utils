using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Messages;

namespace game66Utils.Actors
{
    public class ParseInputRowActor : OneTypeReceiveActor<FileRow, PriceRow>
    {
        protected override async Task<PriceRow> Handle(FileRow message)
        {
            if (string.IsNullOrEmpty(message.Id) || string.IsNullOrEmpty(message.Price))
                return null;

            var dString = message.Price.Replace(",", ".");

            decimal price;
            if (Decimal.TryParse(dString, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out price))
            {
                return new PriceRow
                {
                    Id = message.Id,
                    Price = price
                };
            }

            return null;
        }
    }
}
