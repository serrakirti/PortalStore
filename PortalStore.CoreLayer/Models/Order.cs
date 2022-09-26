using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AdressId { get; set; }
        public decimal TotalPrice { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Adress Adress { get; set; }
    }
}
