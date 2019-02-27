using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEB27
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcesser = new OrderProcesser();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100F };
            orderProcesser.Process(order);
        }
    }
}
