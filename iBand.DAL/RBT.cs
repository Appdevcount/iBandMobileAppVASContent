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
    
    public partial class RBT
    {
        public int ID { get; set; }
        public Nullable<int> ToneID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string ProductID { get; set; }
        public string RBTName { get; set; }
        public string RBTDesc { get; set; }
        public string UserMsg { get; set; }
        public string ShortCode { get; set; }
        public Nullable<int> ValidityPeriod { get; set; }
        public string Price { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
    
        public virtual Operator Operator { get; set; }
        public virtual Tone Tone { get; set; }
    }
}
