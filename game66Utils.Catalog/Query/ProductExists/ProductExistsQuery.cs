using System;
using System.Linq;
using game66Utils.Database;

namespace game66Utils.Catalog.Query.ProductExists
{
    internal class ProductExistsQuery : IProductExistsQuery
    {
        public bool Exist(string barCode, Guid categoryId)
        {
            using (var context = new MyDbContext())
            {
                var stringCatId = categoryId.ToString();
                return context.Products.Any(x => x.Barcode == barCode && x.CategoryId == stringCatId);
            }
        }
    }
}