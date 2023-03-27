using DEMO_UNITOFWORK.Models;
using DEMO_UNITOFWORK.Repository;

namespace DEMO_UNITOFWORK.Services
{
    public class OrderServiceImp : IOrderRepository
    {
        private DatabaseContext dbContext;

        public OrderServiceImp(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddOrder(Order order)
        {
          dbContext.Orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
          return dbContext.Orders.ToList();
        }

        public Order OrderGetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }

   
   
}
