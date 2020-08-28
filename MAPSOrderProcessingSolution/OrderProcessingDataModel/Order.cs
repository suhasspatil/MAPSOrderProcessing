using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingDataModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public PaymentType PType { get; set; }
        
    }

    public enum PaymentType
    {
        PhysicalProduct,
        Book,
        Membership,
        UpgradeMembership,
        Video
    }
}
