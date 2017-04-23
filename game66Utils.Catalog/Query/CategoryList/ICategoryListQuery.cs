using System.Collections.Generic;
using System.Threading.Tasks;
using game66Utils.Catalog.Query.CategoryList;

namespace game66Utils.Catalog.Query
{
    public interface ICategoryListQuery
    {
        Task<List<CategoryListDto>> Execute();
    }
}