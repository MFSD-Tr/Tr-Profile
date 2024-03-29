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
    
    public partial class TrkDataTransferField
    {
        public string FieldGroup { get; set; }
        public string ModuleCode { get; set; }
        public string LanguageCode { get; set; }
        public Nullable<short> DTFOrder { get; set; }
        public Nullable<bool> DTFOrderFixed { get; set; }
        public string SourceFieldTable { get; set; }
        public string SourceFieldName { get; set; }
        public Nullable<int> SourceFieldType { get; set; }
        public string DestinationFieldTable { get; set; }
        public string DestinationFieldName { get; set; }
        public Nullable<int> DestinationFieldType { get; set; }
        public string FieldCaption { get; set; }
        public string FieldDescription { get; set; }
        public Nullable<bool> FieldEdit { get; set; }
        public Nullable<bool> FieldIsReference { get; set; }
        public Nullable<bool> IsRate { get; set; }
        public Nullable<bool> Active { get; set; }
        public int DTFieldNumber { get; set; }
        public Nullable<System.DateTime> TrkCreationDate { get; set; }
        public Nullable<int> SecureLevel { get; set; }
        public Nullable<long> UserNumber { get; set; }
        public Nullable<long> UserGroupNumber { get; set; }
        public string DTFSearchMode { get; set; }
    }
}
