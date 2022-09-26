using PortalStore.DTOs;

namespace PortalStore.DTOs
{
    public class AdressWithOrdersDto : AdressDto
    {
       public OrderDto Orders { get; set; }
    }
}
