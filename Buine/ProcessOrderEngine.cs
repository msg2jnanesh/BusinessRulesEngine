using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buine
{
    public class ProcessOrderEngine
    {
        public string ProcessOrder(string type)
        {
            var instance = OrderProcessingFactory.OrderProcessingFactory.GetInstance(type);
            return instance.Process();
        }
    }
}
