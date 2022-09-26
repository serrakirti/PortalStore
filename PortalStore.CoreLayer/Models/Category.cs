using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
