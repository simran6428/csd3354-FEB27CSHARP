using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Orderprocessor = new Orderprocessor();
            var Order = new Order { Dateplaced = DateTime.Now, Totalprice = 100f };
            Orderprocessor.Process(Order);
        }
    }
}
