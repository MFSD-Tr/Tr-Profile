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
    
    public partial class TicketVoid
    {
        public int TicketId { get; set; }
        public string PocketPcId { get; set; }
        public string UserId { get; set; }
        public string ModuleCode { get; set; }
        public string KCode1 { get; set; }
        public string KCode2 { get; set; }
        public string KCode3 { get; set; }
        public string KCode4 { get; set; }
        public string VoidCode { get; set; }
        public string Explanation { get; set; }
        public Nullable<System.DateTime> TicketDate { get; set; }
        public int TrkIndexNumber { get; set; }
        public Nullable<System.DateTime> TrkCreationDate { get; set; }
        public Nullable<int> UserNumber { get; set; }
    }
}
