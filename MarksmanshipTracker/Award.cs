//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarksmanshipTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Award
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Award()
        {
            this.PeopleAwards = new ObservableListSource<PeopleAward>();
        }
    
        public long Id { get; set; }
        public string AwardName { get; set; }
        public Nullable<long> MinCredits { get; set; }
        public string WeaponName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<PeopleAward> PeopleAwards { get; set; }
    }
}
