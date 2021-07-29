using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Order
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public List<LineItem> LineItems { get; set; }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public ShippingAddress Address { get; set; }
    }
    public class LineItem
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class ShippingAddress
    {
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
            
    }
}
