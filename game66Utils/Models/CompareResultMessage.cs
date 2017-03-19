using System;
using System.Collections.Generic;
using System.Linq;

namespace game66Utils.Models
{
    public class CompareResultMessage
    {
        public List<ProductModel> NewProducts { get; set; }
        public List<ProductModel> DeletedProducts { get; set; }

        public List<ProductChangeModel> ChangedPrices { get; set; }

        public CompareResultMessage()
        {
            NewProducts = new List<ProductModel>();
            DeletedProducts = new List<ProductModel>();
            ChangedPrices = new List<ProductChangeModel>();
        }
    }

    public class CompareResult
    {
        private readonly List<CompareResultItem> _compareResult;

        public CompareResult(IEnumerable<CompareResultItem> compareResult)
        {
            _compareResult = compareResult.ToList();
        }

        public List<ProductModel> GetNewProducts()
        {
            return _compareResult.Where(x => x.OldPrice == null).Select(x=>x.NewPrice.Product).ToList();
        }

        public List<ProductModel> GetDeletedProducts()
        {
            return _compareResult.Where(x => x.NewPrice == null).Select(x => x.OldPrice.Product).ToList();
        }

        public List<PriceChanges> GetProductWithPriceChanged()
        {
            return _compareResult
                .Where(x=>x.OldPrice!= null && x.NewPrice != null)
                .Where(x => Math.Abs(x.OldPrice.Price.Price - x.NewPrice.Price.Price) > (decimal) 0.0001)
                .Select(x => new PriceChanges
                {
                    NewPrice = x.NewPrice.Price,
                    OldPrice = x.OldPrice.Price,
                    ProductModel = x.OldPrice.Product
                })
                .ToList();

        }
    }
    public class CompareResultItem
    {
        public PriceListItemModel OldPrice { get; set; }
        public PriceListItemModel NewPrice { get; set; }
    }

    public class PriceChanges
    {
        public ProductModel ProductModel { get; set; }
        public PriceModel OldPrice { get; set; }    
        public PriceModel NewPrice { get; set; }

    }
}