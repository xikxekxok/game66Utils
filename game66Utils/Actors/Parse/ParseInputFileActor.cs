using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;
using game66Utils.Models;
using OfficeOpenXml;

namespace game66Utils.Actors.Parse
{
    public class ParseInputFileActor : OneTypeReceiveActor<UserInputMessage>
    {
        private readonly IActorRef _comparator;
        private IActorRef _rowParser;

        public ParseInputFileActor(IActorRef comparator, IActorRef rowParser) : base()
        {
            _rowParser = rowParser;
            _comparator = comparator;
        }

        protected override async Task Handle(UserInputMessage message)
        {
            using (var package = new ExcelPackage(new FileInfo(message.FileUrl)))
            {
                var result = new List<ProductModel>();

                var sheet = package.Workbook.Worksheets.FirstOrDefault();
                if (sheet == null)
                {
                    throw new FileNotFoundException($"file {message.FileUrl} not found or does not have any sheets");
                }
                var rowCnt = sheet?.Dimension?.End?.Row ?? 0;

                for (int rowNum = 1; rowNum < rowCnt+1; rowNum++)
                {
                    var row = new FileRow
                    {
                        Id = sheet.Cells[message.TitleColumn + rowNum].Value?.ToString(),
                        Price = sheet.Cells[message.PriceColumn + rowNum].Value?.ToString()
                    };

                    var rowModel = await _rowParser.Ask(row) as ProductModel;

                    if (rowModel != null)
                        result.Add(rowModel);
                }

                _comparator.Tell(result);
            }
        }
    }
}
