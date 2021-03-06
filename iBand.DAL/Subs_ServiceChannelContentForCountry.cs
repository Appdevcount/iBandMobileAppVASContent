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
    
    public partial class Subs_ServiceChannelContentForCountry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subs_ServiceChannelContentForCountry()
        {
            this.Subs_ServiceChannelContentConfig = new HashSet<Subs_ServiceChannelContentConfig>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ServiceChannelID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> ChargeDurationType { get; set; }
        public Nullable<int> ChargeDuration { get; set; }
        public Nullable<double> Charge { get; set; }
        public string ChargeType { get; set; }
        public Nullable<int> FreeDurationType { get; set; }
        public Nullable<int> FreeDuration { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_ServiceChannelContentConfig> Subs_ServiceChannelContentConfig { get; set; }
        public virtual Subs_ServiceChannels Subs_ServiceChannels { get; set; }
    }
}
