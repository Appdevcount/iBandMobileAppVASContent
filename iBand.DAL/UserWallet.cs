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
    
    public partial class UserWallet
    {
        public int ID { get; set; }
        public Nullable<long> UserID { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string DeviceUniqueID_ID { get; set; }
        public string DeviceUniqueID { get; set; }
        public string DeviceOS { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AppUsername { get; set; }
        public string AppPassword { get; set; }
        public string CountryCode { get; set; }
        public string Currency { get; set; }
        public string PaymentService { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
    }
}
