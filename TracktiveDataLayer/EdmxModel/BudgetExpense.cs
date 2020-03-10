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
    
    public partial class BudgetExpense
    {
        public string UserId { get; set; }
        public Nullable<int> TicketId { get; set; }
        public Nullable<short> LineNumber { get; set; }
        public string BudgetName { get; set; }
        public Nullable<short> BudgetQuantity { get; set; }
        public Nullable<decimal> BudgetCost { get; set; }
        public Nullable<decimal> BudgetTax1 { get; set; }
        public Nullable<decimal> BudgetTax2 { get; set; }
        public Nullable<decimal> BudgetPrice { get; set; }
        public string BudgetNotes { get; set; }
        public Nullable<System.DateTime> BudgetDate { get; set; }
        public Nullable<int> ItemBudgetTime { get; set; }
        public Nullable<decimal> ItemBudgetAmount { get; set; }
        public Nullable<float> ItemPercentBudgetTime { get; set; }
        public Nullable<float> ItemPercentBudgetAmount { get; set; }
        public Nullable<System.DateTime> TrkCreationDate { get; set; }
        public string BudgetPONumber { get; set; }
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
        public string ItemGroupCode { get; set; }
        public string Account { get; set; }
        public Nullable<int> ItemNumber { get; set; }
        public Nullable<System.DateTime> DateDisplay { get; set; }
        public Nullable<long> NotesNumber { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public long TrkIndexNumber { get; set; }
        public string Currency { get; set; }
        public string DataTable { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public Nullable<bool> SRED { get; set; }
        public Nullable<int> ItemGLExpenseAccountId { get; set; }
        public Nullable<int> ItemGLPurchaseAccountId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    }
}
