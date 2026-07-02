using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ARSOs")]
    public class ARSOsInfo : FixFiveProps
    {
        [Key]
        public int ARSOID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_GEShpMthID { get; set; }
        public int FK_ARSellerID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_LOPlaceID { get; set; }
        public int FK_LODirectionID { get; set; }
        public Boolean ARSOPriority { get; set; }
        public string ARSalePriceCombo { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSellerComAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSellerComPct { get; set; }
        public string ARSOStatusCombo { get; set; } = "New";
        public string ARSOPmtTerm { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOPmtDueDays { get; set; }
        public string ARPmtMthCombo { get; set; } = String.Empty;
        public string ARSONo { get; set; } = String.Empty;
        public string ARSOName { get; set; } = String.Empty;
        public string ARSODesc { get; set; } = String.Empty;
        public Boolean ARSOOnHoldCheck { get; set; }
        public Nullable<DateTime> ARSOReleaseDate { get; set; } = DateTime.Now;
        public string ARSOReleaseBy { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOReleaseTot { get; set; }
        public string ARSOText { get; set; } = String.Empty;
        public Nullable<DateTime> ARSODate { get; set; }=DateTime.Now;
        public int ARSOFiscPer { get; set; }
        public int ARSOFiscYr { get; set; }
        public Nullable<DateTime> ARSOShpDate { get; set; } = DateTime.Now;
        public Nullable<DateTime> ARSOExpireDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSODiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSODiscAmt { get; set; }
        public string ARSORef { get; set; } = String.Empty;
        public string ARSOCusRef { get; set; } = String.Empty;
        public string ARSOComment { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOVol { get; set; }
        public Boolean ARSOActive { get; set; }
        public string ARSOTxNo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOExcRate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCAmt { get; set; }
        public string ARSOTypeCombo { get; set; } = String.Empty;
        public Nullable<DateTime> ARSOPrepaidDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOPrepaidAmt { get; set; }
        public string ARSOOF01Combo { get; set; } = String.Empty;
        public string ARSOOF02Combo { get; set; } = String.Empty;
        public string ARSOOF03Combo { get; set; } = String.Empty;
        public string ARSOOF04Combo { get; set; } = String.Empty;
        public string ARSOOF05Combo { get; set; } = String.Empty;
        public string ARSOOF06Combo { get; set; } = String.Empty;
        public string ARSOOF07Combo { get; set; } = String.Empty;
        public string ARSOOF08Combo { get; set; } = String.Empty;
        public string ARSOOF09Combo { get; set; } = String.Empty;
        public string ARSOOF10Combo { get; set; } = String.Empty;
        public string ARSOPrj { get; set; } = String.Empty;
        public string ARSOCustomerName { get; set; } = String.Empty;
        public string ARSOCustomerDesc { get; set; } = String.Empty;
        public int FK_ARCustomerConBTID { get; set; }
        public string ARSOBTConName { get; set; } = String.Empty;
        public string ARSOBTConFName { get; set; } = String.Empty;
        public string ARSOBTConLName { get; set; } = String.Empty;
        public string ARSOBTConTitle { get; set; } = String.Empty;
        public string ARSOBTConHLet { get; set; } = String.Empty;
        public string ARSOBTConHMsg { get; set; } = String.Empty;
        public string ARSOBTConEmail { get; set; } = String.Empty;
        public string ARSOBTConEmail1 { get; set; } = String.Empty;
        public string ARSOBTConPhone { get; set; } = String.Empty;
        public string ARSOBTConCPhone { get; set; } = String.Empty;
        public string ARSOBTConFax { get; set; } = String.Empty;
        public string ARSOBTConInfo { get; set; } = String.Empty;
        public string ARSOBTConDept { get; set; } = String.Empty;
        public string ARSOBTConRoom { get; set; } = String.Empty;
        public string ARSOBTAddL1 { get; set; } = String.Empty;
        public string ARSOBTAddL2 { get; set; } = String.Empty;
        public string ARSOBTAddL3 { get; set; } = String.Empty;
        public string ARSOBTAddStr { get; set; } = String.Empty;
        public string ARSOBTAddCity { get; set; } = String.Empty;
        public string ARSOBTAddPCode { get; set; } = String.Empty;
        public string ARSOBTAddStProv { get; set; } = String.Empty;
        public string ARSOBTAddZCode { get; set; } = String.Empty;
        public string ARSOBTAddCountry { get; set; } = String.Empty;
        public int FK_ARCustomerConCMID { get; set; }
        public string ARSOCMConName { get; set; } = String.Empty;
        public string ARSOCMConFName { get; set; } = String.Empty;
        public string ARSOCMConLName { get; set; } = String.Empty;
        public string ARSOCMConTitle { get; set; } = String.Empty;
        public string ARSOCMConHLet { get; set; } = String.Empty;
        public string ARSOCMConHMsg { get; set; } = String.Empty;
        public string ARSOCMConEmail { get; set; } = String.Empty;
        public string ARSOCMConEmail1 { get; set; } = String.Empty;
        public string ARSOCMConPhone { get; set; } = String.Empty;
        public string ARSOCMConFax { get; set; } = String.Empty;
        public string ARSOCMConCPhone { get; set; } = String.Empty;
        public string ARSOCMConInfo { get; set; } = String.Empty;
        public string ARSOCMConDept { get; set; } = String.Empty;
        public string ARSOCMConRoom { get; set; } = String.Empty;
        public string ARSOCMAddL1 { get; set; } = String.Empty;
        public string ARSOCMAddL2 { get; set; } = String.Empty;
        public string ARSOCMAddL3 { get; set; } = String.Empty;
        public string ARSOCMAddStr { get; set; } = String.Empty;
        public string ARSOCMAddCity { get; set; } = String.Empty;
        public string ARSOCMAddPCode { get; set; } = String.Empty;
        public string ARSOCMAddStProv { get; set; } = String.Empty;
        public string ARSOCMAddZCode { get; set; } = String.Empty;
        public string ARSOCMAddCountry { get; set; } = String.Empty;
        public int FK_ARCustomerConSTID { get; set; }
        public string ARSOSTConName { get; set; } = String.Empty;
        public string ARSOSTConFName { get; set; } = String.Empty;
        public string ARSOSTConLName { get; set; } = String.Empty;
        public string ARSOSTConTitle { get; set; } = String.Empty;
        public string ARSOSTConHLet { get; set; } = String.Empty;
        public string ARSOSTConHMsg { get; set; } = String.Empty;
        public string ARSOSTConEmail { get; set; } = String.Empty;
        public string ARSOSTConEmail1 { get; set; } = String.Empty;
        public string ARSOSTConPhone { get; set; } = String.Empty;
        public string ARSOSTConCPhone { get; set; } = String.Empty;
        public string ARSOSTConFax { get; set; } = String.Empty;
        public string ARSOSTConInfo { get; set; } = String.Empty;
        public string ARSOSTConDept { get; set; } = String.Empty;
        public string ARSOSTConRoom { get; set; } = String.Empty;
        public string ARSOSTAddL1 { get; set; } = String.Empty;
        public string ARSOSTAddL2 { get; set; } = String.Empty;
        public string ARSOSTAddL3 { get; set; } = String.Empty;
        public string ARSOSTAddStr { get; set; } = String.Empty;
        public string ARSOSTAddCity { get; set; } = String.Empty;
        public string ARSOSTAddPCode { get; set; } = String.Empty;
        public string ARSOSTAddStProv { get; set; } = String.Empty;
        public string ARSOSTAddZCode { get; set; } = String.Empty;
        public string ARSOSTAddCountry { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOShpAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItmPriceTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItmDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItmAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSONetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSORAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOMiscChargeAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCostTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOMargPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCusCrdLimit { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCusOverCrdLimit { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOEstOverCrdLimit { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCusOutStandBalance { get; set; }
        public string ARSOBankName { get; set; } = String.Empty;
        public string ARSOBankAccount { get; set; } = String.Empty;
        public string ARSOReleaseDesc { get; set; } = String.Empty;
        public int FK_HREmployeeID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOSellerQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOProfitPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOProfit { get; set; }
        public string ARSOItemShpPlanStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSORAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOShpPlanQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOShpPlanRQty { get; set; }
        public string ARSOPriorityDesc { get; set; } = String.Empty;
        public string ARSOShpPlanStatusCombo { get; set; } = "New";
        public int ARSOPlaceSortOrder { get; set; }
        public Boolean ARSOIsSplit { get; set; }
        public int FK_ARPmtTermID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFRAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFImpTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFItmAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFItmDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOFItmPriceTot { get; set; }
        public int FK_PMProjectID { get; set; }
        public int FK_BRBranchID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCampaignRAmt { get; set; }
        public int FK_ADApprovalProcID { get; set; }
        public string ApprovalStatusCombo { get; set; } = "New";
        public int FK_ADApprovalProcStepCurrentID { get; set; }
        public string ARSOInvStatusCombo { get; set; } = "New";
        public int FK_CMLeadID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItmFPriceTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItmDiscFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItmFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOTxFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSONetFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSORFAmtTot { get; set; }
        public string ARSOOnHoldRemark { get; set; } = String.Empty;
        public string ARSOLCNo { get; set; } = String.Empty;
        public int FK_GLLCID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public string GLObjectType { get; set; } = String.Empty;
        public int FK_ARPaymentMethodID { get; set; }
        public int FK_BRShipBranchID { get; set; }
        public int ARSODueDay { get; set; }
        public int FK_ARCAID { get; set; }
        public int FK_APSupplierID { get; set; }
        public string ARSOSupAdd { get; set; } = String.Empty;
        public string ARSOOptional01 { get; set; } = String.Empty;
        public string ARSOOptional02 { get; set; } = String.Empty;
        public string ARSOOptional03 { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCusActualBalance { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOCusApprovalSORAmt { get; set; }
        public int FK_ARTradeTermID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOOverLimitPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOOverLimitLv1 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOOverLimitLv2 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOOverLimitLv3 { get; set; }
        public string ARSODestination { get; set; } = String.Empty;
        public string ARSOCStatusCombo { get; set; } = "New";
        public int FK_GLOrgTranCfgID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSODiscPrice { get; set; }
        public int FK_GEIncoTermID { get; set; }
        public int FK_GECurrencyExObjID { get; set; }
        public int FK_ARTransportFormID { get; set; }
        public string AALastApprovalUser { get; set; } = String.Empty;
        public string ARSOSalesDocumentType { get; set; } = String.Empty;
        public string ARSOOptional04 { get; set; } = String.Empty;
        public int ARSOExportCount { get; set; }
        public string ARSOExportStatus { get; set; } = "New";
        public string ARSOClosedReasonCombo { get; set; } = String.Empty;
        public string ARSOClosedReasonDesc { get; set; } = String.Empty;
        public Boolean ARSOProductionHoldCheck { get; set; }
        public string ARSOProductionHoldRemark { get; set; } = String.Empty;
        public int FK_HRWorkingProvinceID { get; set; }
        public int FK_HRDistrictID { get; set; }

    }
}
