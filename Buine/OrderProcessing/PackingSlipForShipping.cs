using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buine.OrderProcessing
{
    internal class PackingSlipForShipping : OrderProcessingBase
    {
        public override string Process()
        {
            return "PackingSlipForShipping Called";
        }
    }
}
