using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace game66Utils.Catalog.Query.ProductExists
{
    public interface IProductExistsQuery
    {
        bool Exist(string barCode, Guid categoryId);
    }
}
