using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingDataModel;
using OrderProcessingService.Interface;

namespace OrderProcessingService.Rules
{
    //Membership Rule - Handle Membership & Upgrade Membership Payment type Rules
    public class MembershipRule : IOrderProcessingRule
    {
        public void ExecuteRule(Order order)
        {
            //Payment is for Membership
            if (order.PType == PaymentType.Membership)
            {
                Constants.OrderStatuses.Add("Activate Membership");
            }
            //Payment is for UpgradeMembership
            if (order.PType == PaymentType.UpgradeMembership)
            {
                Constants.OrderStatuses.Add("Membership Upgrade");
            }
            //Payment is for Membership or UpgradeMembership
            if (order.PType == PaymentType.Membership || order.PType == PaymentType.UpgradeMembership)
            {
                Constants.OrderStatuses.Add("Send Activation Email to User");
            }
        }
    }
}
