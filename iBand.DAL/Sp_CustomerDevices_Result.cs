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
    
    public partial class Sp_CustomerDevices_Result
    {
        public long ID { get; set; }
        public long CustomerID { get; set; }
        public string DeviceUDID { get; set; }
        public string DeviceNotificationID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDae { get; set; }
        public string DeviceInfo { get; set; }
        public string DeviceType { get; set; }
        public string MobileNo { get; set; }
    }
}
