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
    
    public partial class Subs_ServiceChannels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subs_ServiceChannels()
        {
            this.Subs_Billing = new HashSet<Subs_Billing>();
            this.Subs_ContentDelivery = new HashSet<Subs_ContentDelivery>();
            this.Subs_ServiceChannelContentForCountry = new HashSet<Subs_ServiceChannelContentForCountry>();
            this.Subs_UserServiceChannels = new HashSet<Subs_UserServiceChannels>();
            this.Subs_UserSubscriptions = new HashSet<Subs_UserSubscriptions>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public string ServiceChannelName { get; set; }
        public string ServiceChannelDesc { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_Billing> Subs_Billing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_ContentDelivery> Subs_ContentDelivery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_ServiceChannelContentForCountry> Subs_ServiceChannelContentForCountry { get; set; }
        public virtual Subs_Services Subs_Services { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_UserServiceChannels> Subs_UserServiceChannels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_UserSubscriptions> Subs_UserSubscriptions { get; set; }
    }
}
