namespace PortalStore.API.DTOs
{
    public class ProductWithOrderItemDto : ProductDto
    {
        public OrderItemDto OrderItems { get; set; }
    }
}
