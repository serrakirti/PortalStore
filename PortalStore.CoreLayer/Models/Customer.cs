using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.Model
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TcId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gsm { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
