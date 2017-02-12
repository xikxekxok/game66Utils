using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using game66Utils.Messages;

namespace game66Utils.Actors
{
    public class ComparePricesActor : OneTypeReceiveActor<PriceListModel>
    {
        private IActorRef _compareResultSaver;
        private List<PriceRow> _oldPrices;
        private List<PriceRow> _newPrices;
        public ComparePricesActor(
            IActorRef compareResultSaver
            )
        {
            _compareResultSaver = compareResultSaver;
        }

        protected override void PreStart()
        {
            _oldPrices = null;
            _newPrices = null;
        }

        protected override async Task Handle(PriceListModel message)
        {
            switch (message.FileType)
            {
                case FileTypeEnum.Old:
                    _oldPrices = message.Price;
                    break;
                case FileTypeEnum.New:
                    _newPrices = message.Price;
                    break;
            }

            if (_oldPrices != null && _newPrices != null)
            {
                var joinTable = _oldPrices.Join(_newPrices, x => x.Id, x => x.Id,
                    (row, priceRow) => new {oldPrice = row, newPrice = priceRow},
                    StringComparer.InvariantCultureIgnoreCase);

                var result = new CompareResultMessage();
                foreach (var product in joinTable)
                {
                    if (product.newPrice == null)
                }
                _compareResultSaver.Tell(new CompareResultMessage());
            }

        }
    }
}
