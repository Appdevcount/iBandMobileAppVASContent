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
    
    public partial class Subs_Billing
    {
        public int ID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<int> ServiceChannelID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.DateTime> LastBilledDate { get; set; }
        public string LastBillingStatus { get; set; }
        public Nullable<System.DateTime> BillingScheduledDate { get; set; }
        public string BillingStatus { get; set; }
        public Nullable<System.DateTime> BilledDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual Subs_ServiceChannels Subs_ServiceChannels { get; set; }
        public virtual Subs_Services Subs_Services { get; set; }
    }
}
