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
    
    public partial class Subs_ContentOwners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subs_ContentOwners()
        {
            this.Subs_ContentData = new HashSet<Subs_ContentData>();
            this.Subs_ContentGroupConfig = new HashSet<Subs_ContentGroupConfig>();
            this.Subs_ServiceChannelContentConfig = new HashSet<Subs_ServiceChannelContentConfig>();
        }
    
        public int ID { get; set; }
        public string OwnerName { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_ContentData> Subs_ContentData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_ContentGroupConfig> Subs_ContentGroupConfig { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subs_ServiceChannelContentConfig> Subs_ServiceChannelContentConfig { get; set; }
    }
}
