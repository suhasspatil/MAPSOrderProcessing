﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingService;
using OrderProcessingDataModel;
using System.Collections.Generic;

namespace OrderProcessingUnitTesting
{
    [TestClass]
    public class OrderProcessingRuleTest
    {
        [TestMethod]
        public void testRulePaymentForPhyicalProduct()
        {
            Order ord = new Order
            {
                OrderID = 001,
                OrderDate = DateTime.Now,
                PType =  PaymentType.PhysicalProduct 
            };
            OrderProcessing orderProcessingService = new OrderProcessing();
            orderProcessingService.ProcessOrder(ord);
            List<string> checkList = new List<string>()
            {
                "Generate Packing Slip",
                "Generate Comission Payment To Agent"
            };
                        
            Assert.AreEqual(checkList[0], Constants.OrderStatuses[0]);
            Assert.AreEqual(checkList[1], Constants.OrderStatuses[1]);
        }

        [TestMethod]
        public void testRulePaymentForBook()
        {
            Order ord = new Order
            {
                OrderID = 001,
                OrderDate = DateTime.Now,
                PType = PaymentType.Book
            };
            OrderProcessing orderProcessingService = new OrderProcessing();
            orderProcessingService.ProcessOrder(ord);
            List<string> checkList = new List<string>()
            {
                "Generate Dulicate Packing Slip",
                "Generate Comission Payment To Agent"
            };

            Assert.AreEqual(checkList[0], Constants.OrderStatuses[0]);
            Assert.AreEqual(checkList[1], Constants.OrderStatuses[1]);
        }

        [TestMethod]
        public void testRuleForMembership()
        {
            Order ord = new Order
            {
                OrderID = 001,
                OrderDate = DateTime.Now,
                PType = PaymentType.Membership
            };
            OrderProcessing orderProcessingService = new OrderProcessing();
            orderProcessingService.ProcessOrder(ord);
            List<string> checkList = new List<string>()
            {
                "Activate Membership",
                "Send Activation Email to User"
            };

            Assert.AreEqual(checkList[0], Constants.OrderStatuses[0]);
            Assert.AreEqual(checkList[1], Constants.OrderStatuses[1]);
        }
    }
}
