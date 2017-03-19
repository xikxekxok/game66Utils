using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel;
using game66Utils.Models;

namespace game66Utils.Services.Parsers
{
    public class XlsParser : IParser
    {
        private IParseInputRowService _parseInputRowService;

        public XlsParser(IParseInputRowService rowService)
        {
            _parseInputRowService = rowService;
        }
        public PriceListModel Parse(UserInputMessage message)
        {
            FileStream stream = File.Open(message.FileUrl, FileMode.Open, FileAccess.Read);

            //Choose one of either 1 or 2
            //1. Reading from a binary Excel file ('97-2003 format; *.xls)
            using (IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream))
            {


                //Choose one of either 3, 4, or 5
                //3. DataSet - The result of each spreadsheet will be created in the result.Tables
                DataSet table = excelReader.AsDataSet();


                var rowCnt = table.Tables[0].Rows.Count;
                var result = new PriceListModel
                {
                    Items = new List<PriceListItemModel>()
                };

                for (int rowNum = 0; rowNum < rowCnt; rowNum++)
                {
                    var row = new FileRow
                    {
                        Id = table.Tables[0].Rows[rowNum].ItemArray[message.TitleColumn-1]?.ToString(),
                        Price = table.Tables[0].Rows[rowNum].ItemArray[message.PriceColumn-1]?.ToString()
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
