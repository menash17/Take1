using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMe.Execution.Contract.Restaurant.Commands
{
    public class PlacePartialOrderCommand : CommandBase
    {        
        public long ItemId {get; set;} 
        public string ItemDescription { get; set; }
        public string SpecialComment { get; set; }
        public int Quantity { get; set; }
    }
}
