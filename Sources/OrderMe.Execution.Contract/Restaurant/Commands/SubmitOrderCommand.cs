using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Execution.Contract.Restaurant.Commands
{
    public class SubmitOrderCommand : CommandBase
    {
        public DateTime EndTime { get; set; }
    }
}
