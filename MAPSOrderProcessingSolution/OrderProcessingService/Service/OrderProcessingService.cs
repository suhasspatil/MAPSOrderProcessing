using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
using OrderProcessingService.Interface;

namespace OrderProcessingService
{
    public class OrderProcessingService : IOrderProcessing
    {
        public List<string> ProcessOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
