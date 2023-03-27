namespace DEMO_UNITOFWORK.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public string? OrderDetail { get; set; }    
            public bool IsActive { get; set; } 
        public DateTime OrderDate { get; set; }

    }
}
