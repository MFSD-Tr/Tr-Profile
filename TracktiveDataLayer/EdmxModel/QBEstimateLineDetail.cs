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
    
    public partial class QBEstimateLineDetail
    {
        public long PkQBEstimateLineDetailId { get; set; }
        public Nullable<long> FkQBEstimateLineId { get; set; }
        public string TrkTableName { get; set; }
        public Nullable<long> TrkRecordId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> IsSynced { get; set; }
        public Nullable<long> FkTicketId { get; set; }
        public string TicketItem_Rate { get; set; }
        public string TicketItem_RatePercent { get; set; }
        public string TicketItem_Amount { get; set; }
        public string TicketItem_UnitOfMeasure { get; set; }
        public string TicketItem_Quantity { get; set; }
    }
}
