//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TracktiveDataLayer.EdmxModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrkProjectPhaseMap
    {
        public long PkProjectPhaseId { get; set; }
        public Nullable<long> FkProjectId { get; set; }
        public Nullable<long> FkPhaseId { get; set; }
        public string ListIdX { get; set; }
        public string EditSequenceX { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> IsActive { get; set; }
    }
}