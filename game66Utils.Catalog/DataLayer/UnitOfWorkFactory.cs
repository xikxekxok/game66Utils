using game66Utils.Infrastructure;

namespace game66Utils.Catalog.DataLayer
{
    class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new UnitOfWork();
        }
    }
}