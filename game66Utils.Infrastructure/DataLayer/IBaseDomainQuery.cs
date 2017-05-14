using System.Collections.Generic;
using System.Threading.Tasks;

namespace game66Utils.Infrastructure.DataLayer
{
    public interface IBaseDomainQuery<TDomain> where TDomain : class
    {
        Task<List<TDomain>> ToList();
        Task<TDomain> First();
        Task<bool> Any();
        Task<int> Count();
    }
}