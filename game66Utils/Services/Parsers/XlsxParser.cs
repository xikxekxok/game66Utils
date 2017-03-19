using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Models;
using OfficeOpenXml;

namespace game66Utils.Services
{
    public interface IParser
    {
        PriceListModel Parse(UserInputMessage message);
    }
    public class XlsxParser : IParser
    {
        private IParseInputRowService _parseInputRowService;

        public XlsxParser(IParseInputRowService rowService)
        {
            _parseInputRowService = rowService;
        }
        public PriceListModel Parse(UserInputMessage message)
        {

            using (var package = new ExcelPackage(new FileInfo(message.FileUrl)))
            {
                var result = new PriceListModel
                {
                    Items = new List<PriceListItemModel>()
                };

                var sheet = package.Workbook.Worksheets.FirstOrDefault();
                if (sheet == null)
                {
                    throw new FileNotFoundException($"file {message.FileUrl} not found or does not have any sheets");
                }
                var rowCnt = sheet?.Dimension?.End?.Row ?? 0;

                for (int rowNum = 1; rowNum < rowCnt + 1; rowNum++)
                {
                    var row = new FileRow
                    {
                        Id = sheet.Cells[rowNum, message.TitleColumn].Value?.ToString(),
                        Price = sheet.Cells[rowNum, message.PriceColumn].Value?.ToString()
                    };

                    var rowModel = _parseInputRowService.ParsePriceFromRow(row);

                    if (rowModel != null)
                        result.Items.Add(rowModel);
                }

                return result;
            }
        }
    }
}
