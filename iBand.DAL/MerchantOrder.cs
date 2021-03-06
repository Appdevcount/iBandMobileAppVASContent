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
    
    public partial class MerchantOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MerchantOrder()
        {
            this.MerchantOrderItems = new HashSet<MerchantOrderItem>();
        }
    
        public long ID { get; set; }
        public Nullable<int> MerchantUserID { get; set; }
        public string MobileNo { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> TranDate { get; set; }
        public Nullable<System.DateTime> TranDateExpiry { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> isPaid { get; set; }
        public string StatusDescription { get; set; }
        public string PaymentReference { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MerchantOrderItem> MerchantOrderItems { get; set; }
        public virtual MerchantUser MerchantUser { get; set; }
    }
}
