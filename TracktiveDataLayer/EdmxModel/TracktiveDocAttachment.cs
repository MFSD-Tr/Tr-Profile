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
    
    public partial class TracktiveDocAttachment
    {
        public long ReferenceINumber { get; set; }
        public Nullable<long> PrecedecessorINumber { get; set; }
        public Nullable<long> SucessorINumber { get; set; }
        public Nullable<bool> PathIsBroken { get; set; }
        public Nullable<long> UserINumber { get; set; }
        public Nullable<long> UserGroupINumber { get; set; }
        public Nullable<long> SecureLevel { get; set; }
        public string ReferencePath { get; set; }
        public string ReferenceDescription { get; set; }
        public Nullable<long> CreatedByUserINumber { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public string UserIID { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public Nullable<bool> Private { get; set; }
        public System.Guid FileId { get; set; }
        public byte[] AttachedFile { get; set; }
    }
}
