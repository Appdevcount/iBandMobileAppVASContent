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
    
    public partial class ProfilesKYC
    {
        public ProfilesKYC()
        {
            this.ProfilesKYCHistories = new HashSet<ProfilesKYCHistory>();
            this.ProfilesKYCHistories1 = new HashSet<ProfilesKYCHistory>();
        }
    
        public long ID { get; set; }
        public Nullable<long> ProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string PlaceOfBirth { get; set; }
        public string IDProof1No { get; set; }
        public string IDProof1ImageURL { get; set; }
        public string IDProof1ImageURL2 { get; set; }
        public string IDProof2No { get; set; }
        public string IDProof2ImageURL { get; set; }
        public string IDProof2ImageURL2 { get; set; }
        public string IDProof3No { get; set; }
        public string IDProof3ImageURL { get; set; }
        public string IDProof3ImageURL2 { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public Nullable<int> KYCRating { get; set; }
    
        public virtual Profile Profile { get; set; }
        public virtual ICollection<ProfilesKYCHistory> ProfilesKYCHistories { get; set; }
        public virtual ICollection<ProfilesKYCHistory> ProfilesKYCHistories1 { get; set; }
    }
}
