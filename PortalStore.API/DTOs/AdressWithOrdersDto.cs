namespace PortalStore.API.DTOs
{
    public class AdressWithOrdersDto : AdressDto
    {
       public OrderDto Orders { get; set; }
    }
}
