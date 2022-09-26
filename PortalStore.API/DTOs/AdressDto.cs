using System.Text.Json.Serialization;

namespace PortalStore.API.DTOs
{
    public class AdressDto
    {
        private DateTime _date;
        public int Id { get; set; }
        public string AdressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ZipCode { get; set; }
        public int CustomerId { get; set; }
        public byte Status { get; set; }   
        public DateTime CreationDate { get { return _date; } set { _date = DateTime.Now; } }
    }
}
