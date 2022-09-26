using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.Model
{
    public class Adress
    {
        [Key]
        public int Id { get; set; }
        public string AdressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ZipCode { get; set; }
        public int CustomerId { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
