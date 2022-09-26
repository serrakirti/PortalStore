namespace PortalStore.DTOs
{
    public class CategoryWithProdutsDto:CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
