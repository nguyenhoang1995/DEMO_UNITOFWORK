using DEMO_UNITOFWORK.Models;
using DEMO_UNITOFWORK.Repository;

namespace DEMO_UNITOFWORK.Services
{
    public class UnitOfWorkImp : IUnitOfWork
    {
        private readonly DatabaseContext dbContext;
        public IOrderRepository Orders { get;}

        public IProductRepository Products { get; }
        public UnitOfWorkImp(DatabaseContext _dbContext, IOrderRepository _Orders, IProductRepository _Products)
        {
            dbContext = _dbContext;
            Orders = _Orders;
            Products = _Products;
            
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            dbContext.SaveChanges();
        }
    }
}
