using System;
using System.ComponentModel.DataAnnotations;

namespace SanaWebShop.Core.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
