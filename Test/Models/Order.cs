using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? TransactStatusId { get; set; }
        public bool? Deleted { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public string Note { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Status TransactStatus { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
