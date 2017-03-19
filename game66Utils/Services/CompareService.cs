using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Models;

namespace game66Utils.Services
{
    public class CompareService
    {
        private IComparePriceTableService _comparePriceTableService;
        private ICreateResultFileService _createResultFileService;
        private ParserFactory _parserFactory;

        public CompareService(
            ParserFactory parserFactory,
            IComparePriceTableService comparePriceTableService,
            ICreateResultFileService createResultFileService
        )
        {
            _parserFactory = parserFactory;
            _createResultFileService = createResultFileService;
            _comparePriceTableService = comparePriceTableService;
        }
        public byte[] ComparePrices(UserInputMessage oldPriceSettings, UserInputMessage newPriceSettings)
        {
            var oldPrice = _parserFactory.GetParser(oldPriceSettings).Parse(oldPriceSettings);
            var newPrice = _parserFactory.GetParser(newPriceSettings).Parse(newPriceSettings);

            var compareResult = _comparePriceTableService.CompareTables(oldPrice, newPrice);

            var resultFile = _createResultFileService.GenerateResultFile(compareResult);

            return resultFile;
        }
    }
}
