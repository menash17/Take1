using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Execution.Contract.Restaurant
{
    public abstract class CommandBase
    {
        public string RequestId { get; set; }
        public string PartialRequestId { get; set; }
    }
}
