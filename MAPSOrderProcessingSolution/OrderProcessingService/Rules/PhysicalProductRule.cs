using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
using OrderProcessingService.Interface;

namespace OrderProcessingService.Rules
{
    public class PhysicalProductRule : IOrderProcessingRule
    {
        public void ExecuteRule(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
