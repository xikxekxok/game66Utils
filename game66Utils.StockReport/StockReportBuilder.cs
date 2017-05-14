using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Database;

namespace game66Utils.StockReport
{
    public class StockReportBuilder
    {
        public StockReportBuilder()
        {
            
        }

        public List<StockReportDto> CreateReport()
        {
            using (var context = new MyDbContext())
            {
                var report = context.Stocks.Select(x => new StockReportDto
                {
                    Id = x.CategoryId,
                    CategoryName = x.Category.Name,
                    ProductGroups = new List<StockReportProductGroupDto>()
                }).ToList();

                var groups = context.ProductGroups.AsQueryable().Include(x=>x.Products).ToList();

                var stocks = context.ProductStocks.ToList();

                foreach (var group in groups)
                {
                    var productIds = group.Products.Select(x => x.Barcode).ToList();
                    var stockItems =
                        stocks.Where(x => x.CategoryId == group.CategoryId && productIds.Contains(x.BarCode)).ToList();

                    var catItem = report.FirstOrDefault(x => x.Id == group.CategoryId);
                    catItem.ProductGroups.Add(new StockReportProductGroupDto {ProductGroupTitle = group.Title, StockCount = stockItems.Select(x=>x.Quantity).Sum()});
                }
                return report;
            }

            
        }
    }

    public class StockReportDto
    {
        public string CategoryName { get; set; }
        public List<StockReportProductGroupDto> ProductGroups { get; set; }
        public Guid Id { get; set; }
    }

    public class StockReportProductGroupDto
    {
        public string ProductGroupTitle { get; set; }
        public int StockCount { get; set; }
    }
}
