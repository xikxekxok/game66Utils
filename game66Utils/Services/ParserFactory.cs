using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Models;
using game66Utils.Services.Parsers;

namespace game66Utils.Services
{
    public class ParserFactory
    {
        private IParseInputRowService _parseInputRowService;
        public ParserFactory(IParseInputRowService rowService)
        {
            _parseInputRowService = rowService;
        }
        public IParser GetParser(UserInputMessage message)
        {
            if (message.FileUrl.ToLower().EndsWith(".xls"))
                return new XlsParser(_parseInputRowService);

            return new XlsxParser(_parseInputRowService);
        }
    }
}
