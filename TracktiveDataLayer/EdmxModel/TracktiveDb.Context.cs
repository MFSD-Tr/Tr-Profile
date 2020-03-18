﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TracktiveEntity : DbContext
    {
        public TracktiveEntity()
            : base("name=TracktiveEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BudgetDisbursement> BudgetDisbursements { get; set; }
        public virtual DbSet<BudgetExpense> BudgetExpenses { get; set; }
        public virtual DbSet<BudgetMaterial> BudgetMaterials { get; set; }
        public virtual DbSet<BudgetService> BudgetServices { get; set; }
        public virtual DbSet<BudgetTime> BudgetTimes { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ITC_Activity> ITC_Activity { get; set; }
        public virtual DbSet<ITC_Client> ITC_Client { get; set; }
        public virtual DbSet<ITC_Discipline> ITC_Discipline { get; set; }
        public virtual DbSet<ITC_FeeSchedule> ITC_FeeSchedule { get; set; }
        public virtual DbSet<ITC_FeeType> ITC_FeeType { get; set; }
        public virtual DbSet<ITC_Phase> ITC_Phase { get; set; }
        public virtual DbSet<ITC_Project> ITC_Project { get; set; }
        public virtual DbSet<ITC_TicketRateType> ITC_TicketRateType { get; set; }
        public virtual DbSet<ITC_TicketType> ITC_TicketType { get; set; }
        public virtual DbSet<PayrollItem> PayrollItems { get; set; }
        public virtual DbSet<QBAccountDetail> QBAccountDetails { get; set; }
        public virtual DbSet<QBActivityItemServiceMap> QBActivityItemServiceMaps { get; set; }
        public virtual DbSet<QBBill> QBBills { get; set; }
        public virtual DbSet<QBBillLine> QBBillLines { get; set; }
        public virtual DbSet<QBBillLineDetail> QBBillLineDetails { get; set; }
        public virtual DbSet<QBClientCustomerMap> QBClientCustomerMaps { get; set; }
        public virtual DbSet<QBEstimate> QBEstimates { get; set; }
        public virtual DbSet<QBEstimateLine> QBEstimateLines { get; set; }
        public virtual DbSet<QBEstimateLineDetail> QBEstimateLineDetails { get; set; }
        public virtual DbSet<QBGLAccountNumber> QBGLAccountNumbers { get; set; }
        public virtual DbSet<QBProjectJobMap> QBProjectJobMaps { get; set; }
        public virtual DbSet<QBProjectPhaseSubJobMap> QBProjectPhaseSubJobMaps { get; set; }
        public virtual DbSet<QBTimeTracking> QBTimeTrackings { get; set; }
        public virtual DbSet<QBTrkDisbursementItemOtherChargeMap> QBTrkDisbursementItemOtherChargeMaps { get; set; }
        public virtual DbSet<QBTrkExpenseItemOtherChargeMap> QBTrkExpenseItemOtherChargeMaps { get; set; }
        public virtual DbSet<QBTrkMaterialItemNonInventoryMap> QBTrkMaterialItemNonInventoryMaps { get; set; }
        public virtual DbSet<QBTrkServiceItemNonInventoryMap> QBTrkServiceItemNonInventoryMaps { get; set; }
        public virtual DbSet<QBUserEmployeeMap> QBUserEmployeeMaps { get; set; }
        public virtual DbSet<QBUserVendorMap> QBUserVendorMaps { get; set; }
        public virtual DbSet<ReportProjectLogo> ReportProjectLogos { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TicketDisbursement> TicketDisbursements { get; set; }
        public virtual DbSet<TicketExpense> TicketExpenses { get; set; }
        public virtual DbSet<TicketMaterial> TicketMaterials { get; set; }
        public virtual DbSet<TicketReport> TicketReports { get; set; }
        public virtual DbSet<TicketService> TicketServices { get; set; }
        public virtual DbSet<TicketTask> TicketTasks { get; set; }
        public virtual DbSet<TicketTime> TicketTimes { get; set; }
        public virtual DbSet<TicketVoid> TicketVoids { get; set; }
        public virtual DbSet<TracktiveDateCheck> TracktiveDateChecks { get; set; }
        public virtual DbSet<TracktiveDocAttachment> TracktiveDocAttachments { get; set; }
        public virtual DbSet<TracktiveDocReferenceLink> TracktiveDocReferenceLinks { get; set; }
        public virtual DbSet<TracktiveQB_Request> TracktiveQB_Request { get; set; }
        public virtual DbSet<TracktiveQB_Response> TracktiveQB_Response { get; set; }
        public virtual DbSet<TracktiveQB_SYNCDetails> TracktiveQB_SYNCDetails { get; set; }
        public virtual DbSet<TracktiveQB_TransactionLog> TracktiveQB_TransactionLog { get; set; }
        public virtual DbSet<TrkAddInfo> TrkAddInfoes { get; set; }
        public virtual DbSet<TrkAddInfoField> TrkAddInfoFields { get; set; }
        public virtual DbSet<TrkBatchFile> TrkBatchFiles { get; set; }
        public virtual DbSet<TrkBudgetAdjust> TrkBudgetAdjusts { get; set; }
        public virtual DbSet<TrkCategoryContact> TrkCategoryContacts { get; set; }
        public virtual DbSet<trkClientContact> trkClientContacts { get; set; }
        public virtual DbSet<TrkClientInfo> TrkClientInfoes { get; set; }
        public virtual DbSet<TrkCompanyLogo> TrkCompanyLogos { get; set; }
        public virtual DbSet<TrkContactGroup> TrkContactGroups { get; set; }
        public virtual DbSet<TrkDataGroup> TrkDataGroups { get; set; }
        public virtual DbSet<TrkDataTransferField> TrkDataTransferFields { get; set; }
        public virtual DbSet<TrkDetailScreenField> TrkDetailScreenFields { get; set; }
        public virtual DbSet<TrkDictionaryTable> TrkDictionaryTables { get; set; }
        public virtual DbSet<TrkDisbursement> TrkDisbursements { get; set; }
        public virtual DbSet<TrkExpense> TrkExpenses { get; set; }
        public virtual DbSet<TrkFieldAdjust> TrkFieldAdjusts { get; set; }
        public virtual DbSet<TrkFieldDefault> TrkFieldDefaults { get; set; }
        public virtual DbSet<TrkFieldList> TrkFieldLists { get; set; }
        public virtual DbSet<TrkFilterField> TrkFilterFields { get; set; }
        public virtual DbSet<TrkImage> TrkImages { get; set; }
        public virtual DbSet<TrkImageSampleTable> TrkImageSampleTables { get; set; }
        public virtual DbSet<TrkImportExportField> TrkImportExportFields { get; set; }
        public virtual DbSet<TrkImportExportTable> TrkImportExportTables { get; set; }
        public virtual DbSet<TrkIndFieldList> TrkIndFieldLists { get; set; }
        public virtual DbSet<TrkIndTableList> TrkIndTableLists { get; set; }
        public virtual DbSet<TrkLicenseInformation> TrkLicenseInformations { get; set; }
        public virtual DbSet<TrkMaterial> TrkMaterials { get; set; }
        public virtual DbSet<TrkMobileDeviceOSType> TrkMobileDeviceOSTypes { get; set; }
        public virtual DbSet<TrkMobileDevice> TrkMobileDevices { get; set; }
        public virtual DbSet<TrkNotesDetail> TrkNotesDetails { get; set; }
        public virtual DbSet<TrkObjectText> TrkObjectTexts { get; set; }
        public virtual DbSet<TrkPassInfoField> TrkPassInfoFields { get; set; }
        public virtual DbSet<TrkProjectPhaseMap> TrkProjectPhaseMaps { get; set; }
        public virtual DbSet<TrkQueryCondition> TrkQueryConditions { get; set; }
        public virtual DbSet<TrkQuickBookSetting> TrkQuickBookSettings { get; set; }
        public virtual DbSet<TrkRefCurrency> TrkRefCurrencies { get; set; }
        public virtual DbSet<TrkRefSettingsCountry> TrkRefSettingsCountries { get; set; }
        public virtual DbSet<TrkRefSettingState> TrkRefSettingStates { get; set; }
        public virtual DbSet<TrkReportFieldGroupDef> TrkReportFieldGroupDefs { get; set; }
        public virtual DbSet<TrkReportFieldList> TrkReportFieldLists { get; set; }
        public virtual DbSet<TrkReportField> TrkReportFields { get; set; }
        public virtual DbSet<TrkReportObject> TrkReportObjects { get; set; }
        public virtual DbSet<TrkReportTemplateRange> TrkReportTemplateRanges { get; set; }
        public virtual DbSet<TrkSampleImagePath> TrkSampleImagePaths { get; set; }
        public virtual DbSet<TrkScreenFieldGroupDef> TrkScreenFieldGroupDefs { get; set; }
        public virtual DbSet<TrkScreenField> TrkScreenFields { get; set; }
        public virtual DbSet<TrkScreenObject> TrkScreenObjects { get; set; }
        public virtual DbSet<TrkSearch> TrkSearches { get; set; }
        public virtual DbSet<TrkService> TrkServices { get; set; }
        public virtual DbSet<TrkSettingsComputer> TrkSettingsComputers { get; set; }
        public virtual DbSet<TrkSettingsMobile> TrkSettingsMobiles { get; set; }
        public virtual DbSet<TrkSettingsSystem> TrkSettingsSystems { get; set; }
        public virtual DbSet<TrkSettingsUser> TrkSettingsUsers { get; set; }
        public virtual DbSet<TrkSkin> TrkSkins { get; set; }
        public virtual DbSet<TrkSPParameter> TrkSPParameters { get; set; }
        public virtual DbSet<TrkSPTable> TrkSPTables { get; set; }
        public virtual DbSet<TrkSQL> TrkSQLs { get; set; }
        public virtual DbSet<TrkStandardRanx> TrkStandardRanges { get; set; }
        public virtual DbSet<TrkSysFieldList> TrkSysFieldLists { get; set; }
        public virtual DbSet<TrkSysField> TrkSysFields { get; set; }
        public virtual DbSet<TrkSysTable> TrkSysTables { get; set; }
        public virtual DbSet<TrkSysTableList> TrkSysTableLists { get; set; }
        public virtual DbSet<TrkTableDef> TrkTableDefs { get; set; }
        public virtual DbSet<TrkTableDefaultDate> TrkTableDefaultDates { get; set; }
        public virtual DbSet<TrkTableLink> TrkTableLinks { get; set; }
        public virtual DbSet<TrkTableList> TrkTableLists { get; set; }
        public virtual DbSet<TrkTableRelation> TrkTableRelations { get; set; }
        public virtual DbSet<TrkTableRelationDesign> TrkTableRelationDesigns { get; set; }
        public virtual DbSet<TrkTemplateHeadersFooter> TrkTemplateHeadersFooters { get; set; }
        public virtual DbSet<TrkTemplate> TrkTemplates { get; set; }
        public virtual DbSet<TrkTimeSlot> TrkTimeSlots { get; set; }
        public virtual DbSet<TrkTransferLine> TrkTransferLines { get; set; }
        public virtual DbSet<TrkTransferLog> TrkTransferLogs { get; set; }
        public virtual DbSet<TrkUserGroupMember> TrkUserGroupMembers { get; set; }
        public virtual DbSet<TrkUserGroup> TrkUserGroups { get; set; }
        public virtual DbSet<TrkUserMobileDevice> TrkUserMobileDevices { get; set; }
        public virtual DbSet<TrkUserRateSchedule> TrkUserRateSchedules { get; set; }
        public virtual DbSet<TrkUser> TrkUsers { get; set; }
        public virtual DbSet<TrkUserSyncScope> TrkUserSyncScopes { get; set; }
        public virtual DbSet<TrkWorkStationInfo> TrkWorkStationInfoes { get; set; }
        public virtual DbSet<xTicketExpense> xTicketExpenses { get; set; }
        public virtual DbSet<xTicketMaterial> xTicketMaterials { get; set; }
        public virtual DbSet<xTicketService> xTicketServices { get; set; }
        public virtual DbSet<xTicketTime> xTicketTimes { get; set; }
        public virtual DbSet<TrkGridScreen> TrkGridScreens { get; set; }
        public virtual DbSet<TrkTableJoin> TrkTableJoins { get; set; }
    }
}