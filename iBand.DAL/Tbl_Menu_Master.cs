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
    
    public partial class Tbl_Menu_Master
    {
        public int MenuID { get; set; }
        public string MenuTitle { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> MenuOrder { get; set; }
        public string MenuPath { get; set; }
        public string PageTitle { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string MenuIconPath { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string MenuTitleIconPath { get; set; }
    }
}
