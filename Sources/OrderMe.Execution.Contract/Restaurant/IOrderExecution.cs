using OrderMe.Execution.Contract.Restaurant.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Execution.Contract.Restaurant
{
    public class IOrderExecution
    {
        void CreateOrder(CreateOrderCommand command);
        void PlacePartialOrder(PlacePartialOrderCommand command);
        void SubmitOrder(SubmitOrderCommand command);
    }
}
