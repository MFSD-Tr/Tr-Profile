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
    
    public partial class QBTrkMaterialItemNonInventoryMap
    {
        public long PkQBMaterialItemNonInventoryMapId { get; set; }
        public Nullable<long> TrkMaterialId { get; set; }
        public string QBItemNonInventoryListId { get; set; }
        public string QBItemNonInventoryEditSequence { get; set; }
        public Nullable<long> FkSyncId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<bool> IsSynced { get; set; }
        public Nullable<long> FkApprovedUserId { get; set; }
    }
}