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
    
    public partial class USP_Get_Action_Privileges_Result
    {
        public Nullable<int> parentid { get; set; }
        public Nullable<int> sortorder { get; set; }
        public Nullable<int> menuorder { get; set; }
        public int menuid { get; set; }
        public int roleid { get; set; }
        public string menutitle { get; set; }
        public string rolename { get; set; }
        public string CanAdd { get; set; }
        public string CanEdit { get; set; }
        public string CanView { get; set; }
        public string CanReprocess { get; set; }
        public string CanMarkasSettled { get; set; }
        public string CanReprocessByEdit { get; set; }
        public string ParentMenuName { get; set; }
    }
}
