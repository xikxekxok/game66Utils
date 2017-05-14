using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game66Utils.Catalog.DataLayer;
using game66Utils.Catalog.Domain;
using game66Utils.Database;

namespace game66Utils.Catalog.Command.Impl
{
    class AddCategoryCommand : IAddCategoryCommand
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;

        AddCategoryCommand(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<Guid> Execute(string categoryName)
        {
            using (var uof = _unitOfWorkFactory.Create())
            {
                var id = Guid.NewGuid();
                var category = new Category(new CategoryId(id), categoryName);
                uof.Add(category);

                await uof.Commit();

                return id;
            }
        }
    }
}
