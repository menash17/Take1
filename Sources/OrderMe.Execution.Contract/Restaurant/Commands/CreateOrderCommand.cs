using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Execution.Contract.Restaurant.Commands
{
    public class CreateOrderCommand : CommandBase
    {
        public long UserId { get; set; }
        public int TableNumber { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
