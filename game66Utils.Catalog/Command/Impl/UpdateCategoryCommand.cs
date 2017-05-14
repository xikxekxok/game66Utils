using System;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Domain;
using game66Utils.Infrastructure.DataLayer;

namespace game66Utils.Catalog.Command.Impl
{
    internal class UpdateCategoryCommand : IUpdateCategoryCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        internal UpdateCategoryCommand(
            IUnitOfWorkFactory unitOfWorkFactory
        )
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Execute(Guid id, string categoryName)
        {
            using(IBaseUnitOfWork uof = _unitOfWorkFactory.Create())
            {
                Category category = await uof.Query<ICategoryDomainQuery>()
                    .ById(id)
                    .First();

                if (category == null)
                    throw new Exception($"Category with id {id} not found!");

                category.Update(categoryName);
                
                await uof.Commit();
            }
        }
    }
}