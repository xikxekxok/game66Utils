using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using game66Utils.Catalog.Query.CategoryList;

namespace game66Utils.Catalog.Query
{
    public class FakeCategoryListQuery : ICategoryListQuery
    {
        public async Task<List<CategoryListDto>> Execute()
        {
            return new List<CategoryListDto>
            {
                new CategoryListDto {Id =Guid.NewGuid(), Name = "qqqq", ProductCount = 10},
                new CategoryListDto {Id = Guid.NewGuid(), Name = "sdgfsdfs", ProductCount = 0},
            };
        }
    }
}