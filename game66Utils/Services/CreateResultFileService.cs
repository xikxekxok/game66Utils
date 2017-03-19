using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Models;
using OfficeOpenXml;

namespace game66Utils.Services
{
    public interface ICreateResultFileService
    {
        byte[] GenerateResultFile(CompareResult compareResult);
    }

    public class CreateResultFileService : ICreateResultFileService
    {
        public byte[] GenerateResultFile(CompareResult compareResult)
        {
            using (var package = new ExcelPackage())
            {
                package.Workbook.Properties.Author = "Mont";

                var newProdsSheet = package.Workbook.Worksheets.Add("Новые товары");
                var newProducts = compareResult.GetNewProducts();
                for (int i = 0; i < newProducts.Count; i++)
                {
                    newProdsSheet.Cells[i+1, 1].Value = newProducts[i].Id;
                }

                var delProdsSheet = package.Workbook.Worksheets.Add("Удаленные товары");
                var delProducts = compareResult.GetDeletedProducts();
                for (int i = 0; i < delProducts.Count; i++)
                {
                    delProdsSheet.Cells[i+1, 1].Value = delProducts[i].Id;
                }


                var changeSheets = package.Workbook.Worksheets.Add("Изменилась цена");
                var changed = compareResult.GetProductWithPriceChanged();
                changeSheets.Cells[1, 1].Value = "Ид товара";
                changeSheets.Cells[1, 2].Value = "Старая цена";
                changeSheets.Cells[1, 3].Value = "Новая цена";

                for (int i = 0; i < changed.Count; i++)
                {
                    changeSheets.Cells[i+2, 1].Value = changed[i].ProductModel.Id;
                    changeSheets.Cells[i+2, 2].Value = changed[i].OldPrice.Price;
                    changeSheets.Cells[i+2, 3].Value = changed[i].NewPrice.Price;
                }

                return package.GetAsByteArray();
            }
        }
    }
}
