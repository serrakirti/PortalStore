namespace PortalStore.DTOs
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
