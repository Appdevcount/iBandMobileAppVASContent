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
    
    public partial class ServicesConfig
    {
        public int ID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string ProductID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }
        public string UserMsg { get; set; }
        public string ShortCode { get; set; }
        public Nullable<int> VaidityPeriod { get; set; }
        public string Price { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string ImageURL { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Operator Operator { get; set; }
        public virtual Service Service { get; set; }
    }
}
