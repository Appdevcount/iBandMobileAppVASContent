//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iBand.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoyaltyCustomerCard
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public Nullable<long> CustomerID { get; set; }
        public Nullable<int> LoyaltyCardTypeID { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public Nullable<int> ExpiryMonth { get; set; }
        public Nullable<int> ExpiryYear { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual LoyaltyCardType LoyaltyCardType { get; set; }
    }
}
