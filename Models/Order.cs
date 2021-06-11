using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSample.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFullfilled { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ProductOrders> Orders { get; set; }
    }
}
