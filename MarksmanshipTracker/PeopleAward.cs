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
    
    public partial class PeopleAward
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public long AwardId { get; set; }
        public Nullable<System.DateTime> DateAwarded { get; set; }
    
        public virtual Award Award { get; set; }
        public virtual Person Person { get; set; }
    }
}
