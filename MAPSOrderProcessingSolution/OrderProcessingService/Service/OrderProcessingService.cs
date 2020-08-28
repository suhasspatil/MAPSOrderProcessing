using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
using OrderProcessingService.Interface;
using OrderProcessingService.Rules;

namespace OrderProcessingService
{
    //Problem Statement 2 : Business Rule Engine for Order Processing 
    public class OrderProcessing : IOrderProcessing
    {
        //Order Prcoessing List - Rules needs to be executed on Order
        List<IOrderProcessingRule> Rules = new List<IOrderProcessingRule>();

        //Constructor
        public OrderProcessing()
        {
            //Adding Physical Product Rule - Handle Physical Product & Book Payment type
            Rules.Add(new PhysicalProductRule());
            //Adding Membership Rule Rule - Handle Membership & Upgrade Membership Payment type
            Rules.Add(new MembershipRule());
            //Adding Video Learning Rule - Handle Video 'Learning to Ski' Payment type
            Rules.Add(new VideoLearningRule());

            //New Rules can be added here for future requirment . 
           
        }

        //Process Order handle all kind of Orders .
        public List<string> ProcessOrder(Order order)
        {
            //Clear all Rules Exceution Statuses
            Constants.OrderStatuses.Clear();

            // Going through Rules
            foreach (IOrderProcessingRule rule in Rules)
            {
                //Executing Rule
                rule.ExecuteRule(order);
            }

            //Return Rule Status 
            return Constants.OrderStatuses;
        }
    }
}
