namespace PortalStore.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AdressId { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
