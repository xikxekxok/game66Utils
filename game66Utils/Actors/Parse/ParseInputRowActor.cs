﻿using System;
using System.Globalization;
using System.Threading.Tasks;
using game66Utils.Models;

namespace game66Utils.Actors.Parse
{
    public class ParseInputRowActor : OneTypeReceiveActor<FileRow, PriceListItemModel>
    {
        protected override async Task<PriceListItemModel> Handle(FileRow message)
        {
            if (string.IsNullOrEmpty(message.Id) || string.IsNullOrEmpty(message.Price))
                return null;

            var dString = message.Price.Replace(",", ".");

            decimal price;
            if (Decimal.TryParse(dString, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out price))
            {
                return new PriceListItemModel
                {
                    Product = new ProductModel
                    {
                        Id = message.Id
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
