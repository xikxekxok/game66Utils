using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.Domain;

namespace game66Utils.Catalog.Query.SimularGroup
{
    public interface ISimularGroupQuery
    {
        Task<List<SimularGroupDto>> SimularByTitle(string searchString, Guid categoryId);
    }
}
