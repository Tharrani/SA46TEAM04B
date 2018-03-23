//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAV1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facility()
        {
            this.BookingTrans = new HashSet<BookingTran>();
        }
    
        public short FacilityID { get; set; }
        public string FacilityName { get; set; }
        public string Venue { get; set; }
        public string Sports { get; set; }
        public Nullable<float> RentalPrice { get; set; }
        public Nullable<short> TotalSlots { get; set; }
        public Nullable<short> SlotBooked { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingTran> BookingTrans { get; set; }
    }
}
