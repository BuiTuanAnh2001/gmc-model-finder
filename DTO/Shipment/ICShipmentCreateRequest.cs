using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Shipment
{
    public class ICShipmentCreateRequest : FixFiveProps
    {
        public int ICShipmentID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_GEShpMthID { get; set; }
        public int FK_ARSellerID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_LOShpPlanID { get; set; }
        public int FK_LOCarID { get; set; }
        public int FK_LODirectionID { get; set; }
        public int FK_ICDistributionRuleID { get; set; }
        public decimal ICSellerComAmt { get; set; }
        public decimal ICSellerComPct { get; set; }
        public string ICSalePriceCombo { get; set; } = string.Empty;
        public string ICShipmentStatusCombo { get; set; } = "New";
        public string ICShipmentPmtTerm { get; set; } = string.Empty;
        public decimal ICShipmentPmtDueDays { get; set; }
        public string ICPmtMthCombo { get; set; } = string.Empty;
        public string ICShipmentNo { get; set; } = string.Empty;
        public string ICShipmentName { get; set; } = string.Empty;
        public string ICShipmentDesc { get; set; } = string.Empty;
        public Boolean ICShipmentOnHoldCheck { get; set; }
        public string ICShipmentText { get; set; } = string.Empty;
        public Nullable<DateTime> ICShipmentDate { get; set; }
        public int ICShipmentFiscPer { get; set; }
        public int ICShipmentFiscYr { get; set; }
        public Nullable<DateTime> ICShipmentShpDate { get; set; }
        public Nullable<DateTime> ICShipmentExpireDate { get; set; }
        public decimal ICShipmentDiscPct { get; set; }
        public decimal ICShipmentDiscAmt { get; set; }
        public string ICShipmentRef { get; set; } = string.Empty;
        public string ICShipmentCusRef { get; set; } = string.Empty;
        public string ICShipmentComment { get; set; } = string.Empty;
        public decimal ICShipmentWeight { get; set; }
        public decimal ICShipmentVol { get; set; }
        public Boolean ICShipmentActive { get; set; }
        public string ICShipmentTxNo { get; set; } = string.Empty;
        public decimal ICShipmentExcRate { get; set; }
        public decimal ICShipmentAmt { get; set; }
        public decimal ICShipmentCAmt { get; set; }
        public string ICShipmentSubType { get; set; } = string.Empty;
        public string ICShipmentOF01Combo { get; set; } = string.Empty;
        public string ICShipmentOF02Combo { get; set; } = string.Empty;
        public string ICShipmentOF03Combo { get; set; } = string.Empty;
        public string ICShipmentOF04Combo { get; set; } = string.Empty;
        public string ICShipmentOF05Combo { get; set; } = string.Empty;
        public string ICShipmentOF06Combo { get; set; } = string.Empty;
        public string ICShipmentOF07Combo { get; set; } = string.Empty;
        public string ICShipmentOF08Combo { get; set; } = string.Empty;
        public string ICShipmentOF09Combo { get; set; } = string.Empty;
        public string ICShipmentOF10Combo { get; set; } = string.Empty;
        public string ICShipmentPrj { get; set; } = string.Empty;
        public string ICShipmentCustomerName { get; set; } = string.Empty;
        public string ICShipmentCustomerDesc { get; set; } = string.Empty;
        public int FK_ARCustomerConBTID { get; set; }
        public string ICShipmentBTConName { get; set; } = string.Empty;
        public string ICShipmentBTConFName { get; set; } = string.Empty;
        public string ICShipmentBTConLName { get; set; } = string.Empty;
        public string ICShipmentBTConTitle { get; set; } = string.Empty;
        public string ICShipmentBTConHLet { get; set; } = string.Empty;
        public string ICShipmentBTConHMsg { get; set; } = string.Empty;
        public string ICShipmentBTConEmail { get; set; } = string.Empty;
        public string ICShipmentBTConEmail1 { get; set; } = string.Empty;
        public string ICShipmentBTConPhone { get; set; } = string.Empty;
        public string ICShipmentBTConCPhone { get; set; } = string.Empty;
        public string ICShipmentBTConFax { get; set; } = string.Empty;
        public string ICShipmentBTConInfo { get; set; } = string.Empty;
        public string ICShipmentBTConDept { get; set; } = string.Empty;
        public string ICShipmentBTConRoom { get; set; } = string.Empty;
        public string ICShipmentBTAddL1 { get; set; } = string.Empty;
        public string ICShipmentBTAddL2 { get; set; } = string.Empty;
        public string ICShipmentBTAddL3 { get; set; } = string.Empty;
        public string ICShipmentBTAddStr { get; set; } = string.Empty;
        public string ICShipmentBTAddCity { get; set; } = string.Empty;
        public string ICShipmentBTAddPCode { get; set; } = string.Empty;
        public string ICShipmentBTAddStProv { get; set; } = string.Empty;
        public string ICShipmentBTAddZCode { get; set; } = string.Empty;
        public string ICShipmentBTAddCountry { get; set; } = string.Empty;
        public int FK_ARCustomerConCMID { get; set; }
        public string ICShipmentCMConName { get; set; } = string.Empty;
        public string ICShipmentCMConFName { get; set; } = string.Empty;
        public string ICShipmentCMConLName { get; set; } = string.Empty;
        public string ICShipmentCMConTitle { get; set; } = string.Empty;
        public string ICShipmentCMConHLet { get; set; } = string.Empty;
        public string ICShipmentCMConHMsg { get; set; } = string.Empty;
        public string ICShipmentCMConEmail { get; set; } = string.Empty;
        public string ICShipmentCMConEmail1 { get; set; } = string.Empty;
        public string ICShipmentCMConPhone { get; set; } = string.Empty;
        public string ICShipmentCMConCPhone { get; set; } = string.Empty;
        public string ICShipmentCMConFax { get; set; } = string.Empty;
        public string ICShipmentCMConInfo { get; set; } = string.Empty;
        public string ICShipmentCMConDept { get; set; } = string.Empty;
        public string ICShipmentCMConRoom { get; set; } = string.Empty;
        public string ICShipmentCMAddL1 { get; set; } = string.Empty;
        public string ICShipmentCMAddL2 { get; set; } = string.Empty;
        public string ICShipmentCMAddL3 { get; set; } = string.Empty;
        public string ICShipmentCMAddStr { get; set; } = string.Empty;
        public string ICShipmentCMAddCity { get; set; } = string.Empty;
        public string ICShipmentCMAddPCode { get; set; } = string.Empty;
        public string ICShipmentCMAddStProv { get; set; } = string.Empty;
        public string ICShipmentCMAddZCode { get; set; } = string.Empty;
        public string ICShipmentCMAddCountry { get; set; } = string.Empty;
        public int FK_ARCustomerConSTID { get; set; }
        public string ICShipmentSTConName { get; set; } = string.Empty;
        public string ICShipmentSTConFName { get; set; } = string.Empty;
        public string ICShipmentSTConLName { get; set; } = string.Empty;
        public string ICShipmentSTConTitle { get; set; } = string.Empty;
        public string ICShipmentSTConHLet { get; set; } = string.Empty;
        public string ICShipmentSTConHMsg { get; set; } = string.Empty;
        public string ICShipmentSTConEmail { get; set; } = string.Empty;
        public string ICShipmentSTConEmail1 { get; set; } = string.Empty;
        public string ICShipmentSTConPhone { get; set; } = string.Empty;
        public string ICShipmentSTConCPhone { get; set; } = string.Empty;
        public string ICShipmentSTConFax { get; set; } = string.Empty;
        public string ICShipmentSTConInfo { get; set; } = string.Empty;
        public string ICShipmentSTConDept { get; set; } = string.Empty;
        public string ICShipmentSTConRoom { get; set; } = string.Empty;
        public string ICShipmentSTAddL1 { get; set; } = string.Empty;
        public string ICShipmentSTAddL2 { get; set; } = string.Empty;
        public string ICShipmentSTAddL3 { get; set; } = string.Empty;
        public string ICShipmentSTAddStr { get; set; } = string.Empty;
        public string ICShipmentSTAddCity { get; set; } = string.Empty;
        public string ICShipmentSTAddPCode { get; set; } = string.Empty;
        public string ICShipmentSTAddStProv { get; set; } = string.Empty;
        public string ICShipmentSTAddZCode { get; set; } = string.Empty;
        public string ICShipmentSTAddCountry { get; set; } = string.Empty;
        public decimal ICShipmentShpAmt { get; set; }
        public decimal ICShipmentItmPriceTot { get; set; }
        public decimal ICShipmentItmDiscAmtTot { get; set; }
        public decimal ICShipmentItmAmtTot { get; set; }
        public decimal ICShipmentTxAmtTot { get; set; }
        public decimal ICShipmentNetAmtTot { get; set; }
        public decimal ICShipmentAmtTot { get; set; }
        public decimal ICShipmentMiscChargeAmt { get; set; }
        public decimal ICShipmentCostTot { get; set; }
        public decimal ICShipmentMargPct { get; set; }
        public string ICShipmentStatus { get; set; } = "New";
        public int ICShipmentHoldTot { get; set; }
        public decimal ICShipmentWCapTot { get; set; }
        public decimal ICShipmentVCapTot { get; set; }
        public decimal ICShipmentDistance { get; set; }
        public int FK_PPWOID { get; set; }
        public string AAPostStatus { get; set; } = "New";
        public int FK_HRDepartmentID { get; set; }
        public string ICShipmentEquipmentTypeCombo { get; set; } = string.Empty;
        public int FK_ICShipmentTypeID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public decimal ICShipmentRAmtTot { get; set; }
        public Boolean ICShipmentAutoCreateWarantyCheck { get; set; }
        public decimal ICShipmentFRAmtTot { get; set; }
        public decimal ICShipmentFAmtTot { get; set; }
        public decimal ICShipmentFImpTxAmtTot { get; set; }
        public decimal ICShipmentFTxAmtTot { get; set; }
        public decimal ICShipmentFItmAmtTot { get; set; }
        public decimal ICShipmentFItmDiscAmtTot { get; set; }
        public decimal ICShipmentFItmPriceTot { get; set; }
        public int FK_PMProjectID { get; set; }
        public string AALastPostNo { get; set; } = string.Empty;
        public Nullable<DateTime> AALastPostDate { get; set; }
        public string ICShipmentWarantyStatus { get; set; } = string.Empty;
        public string ICShipmentTypeCombo { get; set; } = string.Empty;
        public string SaleReturnStatusCombo { get; set; } = string.Empty;
        public decimal ICShipmentDiscFAmt { get; set; }
        public decimal ICShipmentDriverPmtAmtTot { get; set; }
        public decimal ICShipmentItmFPriceTot { get; set; }
        public decimal ICShipmentItmDiscFAmtTot { get; set; }
        public decimal ICShipmentItmFAmtTot { get; set; }
        public decimal ICShipmentTxFAmtTot { get; set; }
        public decimal ICShipmentNetFAmtTot { get; set; }
        public decimal ICShipmentRFAmtTot { get; set; }
        public int FK_ARContractID { get; set; }
        public string ICShipmentApprovalStatusCombo { get; set; } = string.Empty;
        public string ICShipmentCarNo { get; set; } = string.Empty;
        public string ICShipmentContNo { get; set; } = string.Empty;
        public string ICShipmentSealNo { get; set; } = string.Empty;
        public string ApprovalStatusCombo { get; set; } = "New";
        public int FK_ICCarryTypeID { get; set; }
        public int FK_ICCarrierTeamID { get; set; }
        public string ICShipmentInvNo { get; set; } = string.Empty;
        public string ICServiceChargeStatusCombo { get; set; } = string.Empty;
        public string ICServiceChargeLastUser { get; set; } = string.Empty;
        public string ICShipmentVoucherRefNo { get; set; } = string.Empty;
        public string APPurchaseReturnStatusCombo { get; set; } = string.Empty;
        public int FK_ARCustomerOwnerID { get; set; }
        public int FK_LOPortPOLID { get; set; }
        public int FK_LOPortPODID { get; set; }
        public Nullable<DateTime> ICShipmentETDDate { get; set; }
        public Nullable<DateTime> ICShipmentETADate { get; set; }
        public Nullable<DateTime> ICShipmentReceivedDate { get; set; }
        public int FK_ARShipperID { get; set; }
        public string ICShipmentShipperTaxNo { get; set; } = string.Empty;
        public string ICShipmentShipperAddress { get; set; } = string.Empty;
        public int FK_ARConsigneeID { get; set; }
        public string ICShipmentConsigneeTaxNo { get; set; } = string.Empty;
        public string ICShipmentConsigneeAddress { get; set; } = string.Empty;
        public int FK_LOAgentID { get; set; }
        public string ICShipmentAgentTaxNo { get; set; } = string.Empty;
        public string ICShipmentAgentAddress { get; set; } = string.Empty;
        public int FK_LOCarrierID { get; set; }
        public string ICShipmentCarrierTaxNo { get; set; } = string.Empty;
        public string ICShipmentCarrierAddress { get; set; } = string.Empty;
        public string ICShipmentPONo { get; set; } = string.Empty;
        public int FK_GLTranCfgID { get; set; }
        public string ICShipmentLPortName { get; set; } = string.Empty;
        public string ICShipmentDPortName { get; set; } = string.Empty;
        public string ICShipmentConsigneeName { get; set; } = string.Empty;
        public string ICShipmentShipperName { get; set; } = string.Empty;
        public string ICShipmentAgentName { get; set; } = string.Empty;
        public string ICShipmentCarrierName { get; set; } = string.Empty;
        public int FK_LOConsigneeID { get; set; }
        public string ICShipmentLotNo { get; set; } = string.Empty;
        public string AACompanyTypeCombo { get; set; } = string.Empty;
        public string AAThueRemark { get; set; } = string.Empty;
        public Nullable<DateTime> ICShipmentCPSIADateOfIssue { get; set; }
        public string ICShipmentCPSIACertificateNo { get; set; } = string.Empty;
        public string ICShipmentCPSIALabReportNo { get; set; } = string.Empty;
        public Nullable<DateTime> ICShipmentCPSIAReportCreatedDate { get; set; }
        public Nullable<DateTime> ICShipmentCPSIAROMFromDate { get; set; }
        public Nullable<DateTime> ICShipmentCPSIAROMToDate { get; set; }
        public string AAOrgDocNo { get; set; } = string.Empty;
        public string ICShipmentLCNo { get; set; } = string.Empty;
        public int FK_ICReceiptID { get; set; }
        public int FK_APSupplierConID { get; set; }
        public string AAModule { get; set; } = string.Empty;
        public Nullable<DateTime> ICShipmentJrnDate { get; set; }
        public int FK_GLLCID { get; set; }
        public int FK_ARSOID { get; set; }
        public string ICShipmentSupAdd { get; set; } = string.Empty;
        public string ICShipmentOptional01 { get; set; } = string.Empty;
        public string ICShipmentOptional02 { get; set; } = string.Empty;
        public string ICShipmentOptional03 { get; set; } = string.Empty;
        public int FK_ARTradeTermID { get; set; }
        public string ICShipmentJrnNo { get; set; } = string.Empty;
        public int FK_GECurrencyExObjID { get; set; }
        public int FK_GEIncoTermID { get; set; }
        public string ICShipmentDestination { get; set; } = string.Empty;
        public int ICShipmentExportCount { get; set; }
        public string ICShipmentExportStatus { get; set; } = string.Empty;
        public int FK_GLOrgTranCfgID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public Boolean ICShipmentAutoAllocateCheck { get; set; }
        public string ICShipmentSaleCostTypeCombo { get; set; } = string.Empty;
        public int FK_ARSaleCostID { get; set; }
        public int FK_HRReceiveEmployeeID { get; set; }
        public int FK_HRSectionID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
    }
}
