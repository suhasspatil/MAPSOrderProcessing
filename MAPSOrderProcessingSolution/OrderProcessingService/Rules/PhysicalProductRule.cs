using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
using OrderProcessingService.Interface;

namespace OrderProcessingService.Rules
{
    //PhysicalProductRule - Handle Physical Product & Book Payment type Rules
    public class PhysicalProductRule : IOrderProcessingRule
    {
        public void ExecuteRule(Order order)
        {
            //Payment is for PhysicalProduct
            if (order.PType == PaymentType.PhysicalProduct)
            {
                Constants.OrderStatuses.Add("Generate Packing Slip");
            }
            //Payment is for Book
            if (order.PType == PaymentType.Book)
            {
                Constants.OrderStatuses.Add("Generate Dulicate Packing Slip");
            }
            //Payment is for PhysicalProduct or Book
            if (order.PType == PaymentType.PhysicalProduct || order.PType == PaymentType.Book)
            {
                Constants.OrderStatuses.Add("Generate Comission Payment To Agent");
            }
        }
    }
}
