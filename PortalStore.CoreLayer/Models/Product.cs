using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate  { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Category Category { get; set; }
    }
}
