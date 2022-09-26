namespace PortalStore.API.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TcId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gsm { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
