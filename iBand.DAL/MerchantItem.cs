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
    
    public partial class MerchantItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MerchantItem()
        {
            this.MerchantCustomerRequests = new HashSet<MerchantCustomerRequest>();
            this.MerchantItemImages = new HashSet<MerchantItemImage>();
            this.MerchantOrderItems = new HashSet<MerchantOrderItem>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public Nullable<int> MerchantID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public string StatusDescription { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public int UpdatedBy { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MerchantCustomerRequest> MerchantCustomerRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MerchantItemImage> MerchantItemImages { get; set; }
        public virtual Merchant Merchant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MerchantOrderItem> MerchantOrderItems { get; set; }
    }
}
