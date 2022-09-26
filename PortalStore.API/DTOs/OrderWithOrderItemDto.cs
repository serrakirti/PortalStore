namespace PortalStore.API.DTOs
{
    public class OrderWithOrderItemDto : OrderDto
    {
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }
}
