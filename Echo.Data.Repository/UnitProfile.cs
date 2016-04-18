//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Echo.Data.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnitProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitProfile()
        {
            this.MonthlyAssociationDue = new HashSet<MonthlyAssociationDue>();
            this.PaymentHistory = new HashSet<PaymentHistory>();
            this.TenantArchive = new HashSet<TenantArchive>();
            this.WaterBilling = new HashSet<WaterBilling>();
        }
    
        public string UnitNumber { get; set; }
        public Nullable<System.DateTime> StartOfOccupancy { get; set; }
        public Nullable<System.DateTime> ExpectedEndOfOccupancy { get; set; }
        public Nullable<System.Guid> Owner { get; set; }
        public Nullable<System.Guid> Tenant { get; set; }
        public string NatureOfOccupancy { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthlyAssociationDue> MonthlyAssociationDue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistory> PaymentHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TenantArchive> TenantArchive { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaterBilling> WaterBilling { get; set; }
    }
}
