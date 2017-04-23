using System;
using System.Threading.Tasks;

namespace game66Utils.Catalog.Command
{
    public interface IUpdateCategoryCommand
    {
        Task Execute(Guid id, string categoryName);
    }
}