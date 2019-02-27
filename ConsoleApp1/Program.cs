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
            var Orderprocessor = new orderprocessor();
            var Order = new Order { Dateplaced = DateTime.Now, TotalPrice = 100f };
            Orderprocessor.process(Order);
        }
    }



    public class orderprocessor
    {
        private readonly ShippingCalculator _ShippingCalculator;
        public orderprocessor()
        {
            _ShippingCalculator = new ShippingCalculator();

        }
        public void process(Order order)
        {
            if (order.Isshipped)
                throw new InvalidOperationException("this order is already processed.");
            order.Shipment = new Shipment
            {
                Cost = _ShippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1);
        }
    }


    public class ShippingCalculator
    {
        public float CalculatingShipping(Order order)
        {
            if (order.TotalPrice < 30f) return order.TotalPrice * 0.1f;
            return 0;
        }
    }

}

