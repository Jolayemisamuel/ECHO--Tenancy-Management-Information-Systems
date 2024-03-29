//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Echo.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TenantProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TenantProfile()
        {
            this.OtherOccupants = new HashSet<OtherOccupants>();
            this.PetsProfile = new HashSet<PetsProfile>();
        }
    
        public System.Guid ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string NatureOfOccupancy { get; set; }
        public string HomeAddress { get; set; }
        public string ProvincialAddress { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public string WithOtherOccupants { get; set; }
        public string WithPets { get; set; }
        public string WithFireExtinguisher { get; set; }
        public string Password { get; set; }
        public byte[] ImageLocation { get; set; }
        public string UnitNumber { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherOccupants> OtherOccupants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PetsProfile> PetsProfile { get; set; }
        public virtual UnitProfile UnitProfile { get; set; }
    }
}
