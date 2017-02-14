using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using game66Utils.Models;

namespace game66Utils.Actors
{
    public class ComparePricesActor : OneTypeReceiveActor<PriceListModel>
    {
        private IActorRef _compareResultSaver;
        public ComparePricesActor(
            IActorRef compareResultSaver
            )
        {
            _compareResultSaver = compareResultSaver;
        }

        protected override void PreStart()
        {
        }

        protected override async Task Handle(PriceListModel message)
        {
            switch (message.PriceType)
            {
                case PriceTypeEnum.Old:
                    _oldPrices = message.Price;
                    break;
                case PriceTypeEnum.New:
                    _newPrices = message.Price;
                    break;
            }

            if (_oldPrices != null && _newPrices != null)
            {
                var joinTable = _oldPrices.FullOuterJoin(_newPrices, x => x.Id, x => x.Id,
                    (row, priceRow, id) => new {oldPrice = row, newPrice = priceRow},
                    null,null,StringComparer.InvariantCultureIgnoreCase);

                var result = new CompareResultMessage();
                foreach (var product in joinTable)
                {
                    if (product.newPrice == null)
                        result.DeletedProducts.Add(product.oldPrice.Id);

                    if (product.oldPrice == null)
                        result.NewProducts.Add(product.newPrice.Id);

                    if (Math.Abs(product.oldPrice.Price - product.newPrice.Price) > (decimal)0.0001)
                    {
                        result.ChangedPrices.Add(new ProductChangeModel
                        {
                            IdProduct = product.oldPrice.Id,
                            NewPrice = product.newPrice.Price,
                            OldPrice = product.oldPrice.Price
                        });
                    }
                }

                _compareResultSaver.Tell(result);
            }

        }
    }
}
