using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Domain;

namespace game66Utils.Catalog.Command.Impl
{
    internal class AddCategoryCommand : IAddCategoryCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        internal AddCategoryCommand(
            IUnitOfWorkFactory unitOfWorkFactory
            )
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<Guid> Execute(string categoryName)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                var repository = uof.CategoryRepository;

                var id = Guid.NewGuid();
                var category = new Category(id, categoryName);
                repository.Add(category);

                await uof.Commit();

                return id;
            }
        }
    }

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
            using(var uof = _unitOfWorkFactory.Create())
            {
                Category category = uof.CategoryRepository.Query().ById(id).FirstOrDefault();
                if (category == null)
                    throw new Exception($"category {id} not found!");

                category.Update(categoryName);

                await uof.Commit();
            }
        }
    }
}
