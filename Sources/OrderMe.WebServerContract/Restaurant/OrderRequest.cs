using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.WebServerContract.Restaurant
{
    public class OrderRequest
    {
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public IEnumerable<OrderItemRequest> Items { get; set; }
    }
}
