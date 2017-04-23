using System;
using System.Threading.Tasks;

namespace game66Utils.Catalog.Command
{
    public interface IAddCategoryCommand
    {
        Task<Guid> Execute(string categoryName);
    }
}
