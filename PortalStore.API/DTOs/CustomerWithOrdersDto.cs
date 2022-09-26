namespace PortalStore.API.DTOs
{
    public class CustomerWithOrdersDto:CustomerDto
    {
        public OrderDto Order { get; set; }
    }
}
