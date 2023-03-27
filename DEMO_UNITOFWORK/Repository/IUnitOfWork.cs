namespace DEMO_UNITOFWORK.Repository
{
    public interface IUnitOfWork
    {
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        void SaveChange();

    }
}
