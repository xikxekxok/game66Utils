using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using game66Utils.Catalog.Query.CategoryList;
using game66Utils.Database;

namespace game66Utils.Catalog.Query
{
    class CategoryListQuery : ICategoryListQuery
    {
        public async Task<List<CategoryListDto>> Execute()
        {
            using (var context = new MyDbContext())
            {
                var list = await context.Categories
                    .Select(x => new
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ProductCount = x.Products.Count
                    })
                    .ToListAsync();
                return list
                    .Select(x => new CategoryListDto
                    {
                        Id = Guid.Parse(x.Id),
                        Name = x.Name,
                        ProductCount = x.ProductCount
                    })
                    .ToList();
            }
        }
    }
}