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
    
    public partial class QBEstimate
    {
        public long PkEstimateId { get; set; }
        public Nullable<long> FkSyncId { get; set; }
        public string EstimateType { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string QBEstimateTxnId { get; set; }
        public string QBEstimateEditSequence { get; set; }
        public Nullable<bool> IsSynced { get; set; }
        public Nullable<long> FkClientId { get; set; }
        public Nullable<long> FkProjectId { get; set; }
        public Nullable<long> FkPhaseId { get; set; }
        public string EstimateFor { get; set; }
        public string QBTxnDate { get; set; }
        public string QBRefNumber { get; set; }
        public string QBEstimateFor_ListId { get; set; }
        public Nullable<long> FkApprovedUserId { get; set; }
    }
}
