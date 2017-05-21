using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Database;

namespace game66Utils.StockReport
{
    public class CsvStockReportBuilder
    {
        public string GetCsvReport(Guid categoryId)
        {
            var report = new StockReportBuilder().CreateReport(categoryId);
            
            var builder = new StringBuilder();
            builder.AppendLine(
                "№;Название;\"ID раздела\";\"Свойство \"\"Мета-описание\"\"\";\"Цена \"\"Розничная цена\"\"\";Остатки;\"Закупочная цена\"");

            foreach (var row in report)
            {
                builder.AppendLine(
                    $";\"{row.Title}\";;;{row.SalePrice};{row.StockCount};{row.PurchasePrice}");
            }

            return builder.ToString();
        }
    }
    internal class StockReportBuilder
    {
        public StockReportBuilder()
        {

        }

        public List<StockReportDto> CreateReport(Guid categoryId)
        {
            using (var context = new MyDbContext())
            {
                var result = new List<StockReportDto>();
                var groups = context.ProductGroups.Where(x => x.CategoryId == categoryId).AsQueryable().Include(x => x.Products).ToList();

                var stocks = context.ProductStocks.Where(x => x.CategoryId == categoryId).ToList();

                foreach (var group in groups)
                {
                    var products = group.Products.GroupBy(x => Decimal.ToInt32(x.SellingPrice * 100)); //идея такая - группируем одинаковые с точностью до 2 знака
                    foreach (var product in products)
                    {
                        var stockItems =
                            stocks.Where(
                                x =>
                                    product.Any(
                                        y => y.Barcode.Equals(x.BarCode, StringComparison.CurrentCultureIgnoreCase)));
                        result.Add(new StockReportDto
                        {
                            Title = group.Title,
                            SalePrice = product.First().SellingPrice,
                            PurchasePrice = product.First().PurchasePrice,
                            StockCount = stockItems.Select(x => x.Quantity).Sum()
                        });
                    }
                }
                return result;
            }


        }
    }

    public class StockReportDto
    {
        public string Title { get; set; }
        public decimal SalePrice { get; set; }
        public int StockCount { get; set; }
        public decimal PurchasePrice { get; set; }
    }

}
