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
    
    public partial class Sp_Customers_Result
    {
        public long ID { get; set; }
        public string CountryCode { get; set; }
        public string CustomerCode { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public Nullable<bool> MobileActivated { get; set; }
        public Nullable<short> OTP { get; set; }
        public string Email { get; set; }
        public Nullable<bool> EmailActivated { get; set; }
        public string CivilID { get; set; }
        public Nullable<bool> CivilIDActivated { get; set; }
        public string AppIdentifier { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public byte[] EncryptedPassword { get; set; }
        public string profileSource { get; set; }
        public byte[] paymentTokenAlias { get; set; }
        public string CardType { get; set; }
    }
}
