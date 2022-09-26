namespace PortalStore.DTOs
{
    public class OrderWithOrderItemDto : OrderDto
    {
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }
}
