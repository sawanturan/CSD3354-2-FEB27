﻿using System;
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


    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InavlidOperationException("This order is already processed.");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f) return order.totalPrice * 0.1f;

            return 0;
        }
    }
}

