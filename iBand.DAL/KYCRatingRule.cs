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
    
    public partial class KYCRatingRule
    {
        public int ID { get; set; }
        public Nullable<int> RuleType { get; set; }
        public Nullable<int> ConfigID { get; set; }
        public Nullable<int> LimitType { get; set; }
        public Nullable<int> LimitValue { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public bool Status { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public string Configuration { get; set; }
        public Nullable<int> KYCRating { get; set; }
    }
}
