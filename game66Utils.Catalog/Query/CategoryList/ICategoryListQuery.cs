using System.Collections.Generic;
using System.Threading.Tasks;

namespace game66Utils.Catalog.Query.CategoryList
{
    public interface ICategoryListQuery
    {
        Task<List<CategoryListDto>> Execute();
    }
}