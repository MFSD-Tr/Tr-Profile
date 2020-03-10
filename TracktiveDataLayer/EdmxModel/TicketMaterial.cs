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
    
    public partial class TicketMaterial
    {
        public string UserId { get; set; }
        public int TicketId { get; set; }
        public Nullable<short> ItemNumber { get; set; }
        public string ItemName { get; set; }
        public Nullable<short> ItemQuantity { get; set; }
        public Nullable<decimal> ItemCost { get; set; }
        public Nullable<decimal> ItemTax1 { get; set; }
        public Nullable<decimal> ItemTax2 { get; set; }
        public Nullable<decimal> ItemPrice { get; set; }
        public string ItemNotes { get; set; }
        public Nullable<System.DateTime> ItemDate { get; set; }
        public string PONumber { get; set; }
        public Nullable<int> ItemBudgetTime { get; set; }
        public Nullable<decimal> ItemBudgetAmount { get; set; }
        public Nullable<float> ItemPercentBudgetTime { get; set; }
        public Nullable<float> ItemPercentBudgetAmount { get; set; }
        public int TrkIndexNumber { get; set; }
        public Nullable<System.DateTime> TrkCreationDate { get; set; }
        public string ItemGroupCode { get; set; }
        public string ItemPONumber { get; set; }
        public string ItemInvoiceNumber { get; set; }
        public Nullable<int> ItemGLIncomeAccountId { get; set; }
        public string ItemWorkOrderNumber { get; set; }
        public Nullable<decimal> ItemTotal { get; set; }
        public Nullable<bool> ItemAcctReimburse { get; set; }
        public Nullable<System.DateTime> ItemAcctExportDate { get; set; }
        public string ItemAcctInvoice { get; set; }
        public Nullable<bool> ItemAcctBillable { get; set; }
        public Nullable<int> TicketIdNumber { get; set; }
        public Nullable<int> ItemIndexNumber { get; set; }
        public Nullable<int> ItemGroupIndexNumber { get; set; }
        public Nullable<int> UserNumber { get; set; }
        public string Account { get; set; }
        public Nullable<System.DateTime> DateDisplay { get; set; }
        public Nullable<long> NotesNumber { get; set; }
        public Nullable<long> LineNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Currency { get; set; }
        public Nullable<short> BudgetOriginalQuantity { get; set; }
        public Nullable<decimal> BudgetOriginalCost { get; set; }
        public Nullable<decimal> BudgetOriginalPrice { get; set; }
        public Nullable<decimal> BudgetOriginalTotal { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public Nullable<bool> SRED { get; set; }
        public Nullable<int> ItemGLExpenseAccountId { get; set; }
        public Nullable<int> ItemGLPurchaseAccountId { get; set; }
        public string EstimateTxnLineID { get; set; }
        public string BillTxnLineID { get; set; }
        public Nullable<bool> IsReimbursement { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    }
}
