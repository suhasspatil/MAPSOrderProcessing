using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
namespace OrderProcessingService.Interface
{
    interface IOrderProcessingRule
    {
        void ExecuteRule(Order order);
    }
}
