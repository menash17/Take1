using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.WebServerContract.Restaurant
{
    public class OrderItemRequest
    {
        public long ItemId { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
    }
}
