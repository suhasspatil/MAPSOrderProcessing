using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;

namespace OrderProcessingService.Interface
{
    interface IOrderProcessing
    {
        List<string> ProcessOrder(Order order);
    }
}
