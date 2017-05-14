using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;

namespace game66Utils.Catalog.Query.SimularGroup
{
    class SimularGroupQuery : ISimularGroupQuery
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public SimularGroupQuery(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }
        public async Task<List<SimularGroupDto>> SimularByTitle(string searchString, Guid categoryId)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                var domainsList = await uof.Query<IProductGroupQuery>(true)
                    .SimularName(searchString)
                    .ByCategoryId(categoryId)
                    .ToList();

                return domainsList.Select(x => new SimularGroupDto
                {
                    GroupId = x.Id.Value,
                    GroupTitle = x.Description.Title
                }).ToList();
            }
        }
    }
}