using System.Threading.Tasks;

namespace game66Utils.Catalog.Command.AddGroup
{
    public interface IAddGroupCommand
    {
        Task Execute(AddGroupContext context);
    }
}