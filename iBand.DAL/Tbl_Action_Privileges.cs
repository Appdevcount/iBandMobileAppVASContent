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
    
    public partial class Tbl_Action_Privileges
    {
        public int ID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> MenuID { get; set; }
        public Nullable<bool> CanAdd { get; set; }
        public Nullable<bool> CanEdit { get; set; }
        public Nullable<bool> CanView { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> CanReprocess { get; set; }
        public Nullable<bool> CanMarkasSettled { get; set; }
        public Nullable<bool> CanReprocessByEdit { get; set; }
    }
}
