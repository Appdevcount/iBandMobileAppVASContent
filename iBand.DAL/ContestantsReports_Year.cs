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
    
    public partial class ContestantsReports_Year
    {
        public int ID { get; set; }
        public Nullable<int> InteractiveServiceID { get; set; }
        public Nullable<int> InteractiveServiceContestantID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Year { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual InteractiveServiceContestant InteractiveServiceContestant { get; set; }
        public virtual InteractiveService InteractiveService { get; set; }
        public virtual Operator Operator { get; set; }
    }
}
