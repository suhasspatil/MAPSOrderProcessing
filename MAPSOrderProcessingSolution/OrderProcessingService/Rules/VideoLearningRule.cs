using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
using OrderProcessingService.Interface;

namespace OrderProcessingService.Rules
{
    //Video Learning Rule - Handle Video 'Learning to Ski' Payment type Rules
    public class VideoLearningRule : IOrderProcessingRule
    {
        public void ExecuteRule(Order order)
        {
            //Payment is for Video
            if (order.PType == PaymentType.Video)
            {
                Constants.OrderStatuses.Add("Add Free Aid Video To Packing Slip");
            }
           
        }
    }
}
