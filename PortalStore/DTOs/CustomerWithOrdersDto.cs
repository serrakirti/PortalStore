namespace PortalStore.DTOs
{
    public class CustomerWithOrdersDto:CustomerDto
    {
        public OrderDto Order { get; set; }
    }
}
