﻿namespace PortalStore.DTOs
{
    public class AdressDto
    {
        public int Id { get; set; }
        public string AdressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ZipCode { get; set; }
        public int CustomerId { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
