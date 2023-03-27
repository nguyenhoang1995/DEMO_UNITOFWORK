using DEMO_UNITOFWORK.Models;
using DEMO_UNITOFWORK.Repository;

namespace DEMO_UNITOFWORK.Services
{
    public class ProductServiceImp : IProductRepository
    {
        private DatabaseContext dbContext;

        public ProductServiceImp(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddProduct(Product product)
        {
           dbContext.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
           return dbContext.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
