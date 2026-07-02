using gmc_api.Base.dto;
using System;

namespace gmc_api.DTO.IC
{
    public class ICReceiptCreateRequest : FixFiveProps
    {
        public int ICReceiptID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_GEShpMthID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ARSellerID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICReceiptStatusCombo { get; set; } = "New";
        public string ICReceiptPmtTerm { get; set; } = String.Empty;
        public string ICPmtMthCombo { get; set; } = String.Empty;
        public string ICReceiptNo { get; set; } = String.Empty;
        public string ICReceiptName { get; set; } = String.Empty;
        public string ICReceiptDesc { get; set; } = String.Empty;
        public string ICReceiptText { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptDate { get; set; }
        public Nullable<DateTime> ICReceiptExpireDate { get; set; }
        public Nullable<DateTime> ICReceiptShpDate { get; set; }
        public Nullable<DateTime> ICReceiptShpDate1 { get; set; }
        public Nullable<DateTime> ICReceiptShpDate2 { get; set; }
        public Boolean ICReceiptIsDiscPctCheck { get; set; }
        public int ICReceiptFiscPer { get; set; }
        public int ICReceiptFiscYr { get; set; }
        public decimal ICReceiptDiscPct { get; set; }
        public decimal ICReceiptDiscAmt { get; set; }
        public string ICReceiptRef { get; set; } = String.Empty;
        public string ICReceiptSupRef { get; set; } = String.Empty;
        public decimal ICReceiptWeight { get; set; }
        public decimal ICReceiptVol { get; set; }
        public Boolean ICReceiptActive { get; set; }
        public string ICReceiptTxNo { get; set; } = String.Empty;
        public decimal ICReceiptExcRate { get; set; }
        public decimal ICReceiptAmt { get; set; }
        public decimal ICReceiptCAmt { get; set; }
        public string ICReceiptSubType { get; set; } = String.Empty;
        public string ICReceiptOF01Combo { get; set; } = String.Empty;
        public string ICReceiptOF02Combo { get; set; } = String.Empty;
        public string ICReceiptOF03Combo { get; set; } = String.Empty;
        public string ICReceiptOF04Combo { get; set; } = String.Empty;
        public string ICReceiptOF05Combo { get; set; } = String.Empty;
        public string ICReceiptOF06Combo { get; set; } = String.Empty;
        public string ICReceiptOF07Combo { get; set; } = String.Empty;
        public string ICReceiptOF08Combo { get; set; } = String.Empty;
        public string ICReceiptOF09Combo { get; set; } = String.Empty;
        public string ICReceiptOF10Combo { get; set; } = String.Empty;
        public string ICReceiptComment { get; set; } = String.Empty;
        public string ICReceiptPrj { get; set; } = String.Empty;
        public int FK_APSupplierConBTID { get; set; }
        public string ICReceiptBTConName { get; set; } = String.Empty;
        public string ICReceiptBTConFName { get; set; } = String.Empty;
        public string ICReceiptBTConLName { get; set; } = String.Empty;
        public string ICReceiptBTConTitle { get; set; } = String.Empty;
        public string ICReceiptBTConHLet { get; set; } = String.Empty;
        public string ICReceiptBTConHMsg { get; set; } = String.Empty;
        public string ICReceiptBTConEmail { get; set; } = String.Empty;
        public string ICReceiptBTConEmail1 { get; set; } = String.Empty;
        public string ICReceiptBTConPhone { get; set; } = String.Empty;
        public string ICReceiptBTConCPhone { get; set; } = String.Empty;
        public string ICReceiptBTConFax { get; set; } = String.Empty;
        public string ICReceiptBTConInfo { get; set; } = String.Empty;
        public string ICReceiptBTConDept { get; set; } = String.Empty;
        public string ICReceiptBTConRoom { get; set; } = String.Empty;
        public string ICReceiptBTAddL1 { get; set; } = String.Empty;
        public string ICReceiptBTAddL2 { get; set; } = String.Empty;
        public string ICReceiptBTAddL3 { get; set; } = String.Empty;
        public string ICReceiptBTAddStr { get; set; } = String.Empty;
        public string ICReceiptBTAddCity { get; set; } = String.Empty;
        public string ICReceiptBTAddPCode { get; set; } = String.Empty;
        public string ICReceiptBTAddStProv { get; set; } = String.Empty;
        public string ICReceiptBTAddZCode { get; set; } = String.Empty;
        public string ICReceiptBTAddCountry { get; set; } = String.Empty;
        public int FK_APSupplierConCMID { get; set; }
        public string ICReceiptCMConName { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptCMConBday { get; set; }
        public string ICReceiptCMConFName { get; set; } = String.Empty;
        public string ICReceiptCMConLName { get; set; } = String.Empty;
        public string ICReceiptCMConTitle { get; set; } = String.Empty;
        public string ICReceiptCMConHLet { get; set; } = String.Empty;
        public string ICReceiptCMConHMsg { get; set; } = String.Empty;
        public string ICReceiptCMConEmail { get; set; } = String.Empty;
        public string ICReceiptCMConEmail1 { get; set; } = String.Empty;
        public string ICReceiptCMConPhone { get; set; } = String.Empty;
        public string ICReceiptCMConCPhone { get; set; } = String.Empty;
        public string ICReceiptCMConFax { get; set; } = String.Empty;
        public string ICReceiptCMConType { get; set; } = String.Empty;
        public string ICReceiptCMConInfo { get; set; } = String.Empty;
        public string ICReceiptCMConDept { get; set; } = String.Empty;
        public string ICReceiptCMConRoom { get; set; } = String.Empty;
        public string ICReceiptCMAddL1 { get; set; } = String.Empty;
        public string ICReceiptCMAddL2 { get; set; } = String.Empty;
        public string ICReceiptCMAddL3 { get; set; } = String.Empty;
        public string ICReceiptCMAddStr { get; set; } = String.Empty;
        public string ICReceiptCMAddCity { get; set; } = String.Empty;
        public string ICReceiptCMAddPCode { get; set; } = String.Empty;
        public string ICReceiptCMAddStProv { get; set; } = String.Empty;
        public string ICReceiptCMAddZCode { get; set; } = String.Empty;
        public string ICReceiptCMAddCountry { get; set; } = String.Empty;
        public int FK_APSupplierShipToID { get; set; }
        public string ICReceiptShipToName { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptShipToBirthday { get; set; }
        public string ICReceiptShipToFName { get; set; } = String.Empty;
        public string ICReceiptShipToLName { get; set; } = String.Empty;
        public string ICReceiptShipToTitle { get; set; } = String.Empty;
        public string ICReceiptShipToHLetter { get; set; } = String.Empty;
        public string ICReceiptShipToHMsg { get; set; } = String.Empty;
        public string ICReceiptShipToEmail1 { get; set; } = String.Empty;
        public string ICReceiptShipToEmail2 { get; set; } = String.Empty;
        public string ICReceiptShipToWebsite { get; set; } = String.Empty;
        public string ICReceiptShipToPhonePriv { get; set; } = String.Empty;
        public string ICReceiptShipToPhone { get; set; } = String.Empty;
        public string ICReceiptShipToPhone1 { get; set; } = String.Empty;
        public string ICReceiptShipToCPhone { get; set; } = String.Empty;
        public string ICReceiptShipToCPhone1 { get; set; } = String.Empty;
        public string ICReceiptShipToCPhonePriv { get; set; } = String.Empty;
        public string ICReceiptShipToFax { get; set; } = String.Empty;
        public string ICReceiptShipToType { get; set; } = String.Empty;
        public string ICReceiptShipToInfo { get; set; } = String.Empty;
        public string ICReceiptShipToDept { get; set; } = String.Empty;
        public string ICReceiptShipToRoom { get; set; } = String.Empty;
        public byte[] ICReceiptShipToImage { get; set; }
        public string ICReceiptShipToAddName { get; set; } = String.Empty;
        public string ICReceiptShipToAddL1 { get; set; } = String.Empty;
        public string ICReceiptShipToAddL2 { get; set; } = String.Empty;
        public string ICReceiptShipToAddL3 { get; set; } = String.Empty;
        public string ICReceiptShipToAddStreet { get; set; } = String.Empty;
        public string ICReceiptShipToAddHouseNumber { get; set; } = String.Empty;
        public string ICReceiptShipToAddCity { get; set; } = String.Empty;
        public string ICReceiptShipToAddPCode { get; set; } = String.Empty;
        public string ICReceiptShipToAddStProv { get; set; } = String.Empty;
        public string ICReceiptShipToAddZCode { get; set; } = String.Empty;
        public string ICReceiptShipToAddCountry { get; set; } = String.Empty;
        public decimal ICReceiptShpFees { get; set; }
        public decimal ICReceiptShpExtraFees { get; set; }
        public decimal ICReceiptShpInsuranceFees { get; set; }
        public decimal ICReceiptShpPackagingFees { get; set; }
        public decimal ICReceiptShpReservedFees1 { get; set; }
        public decimal ICReceiptShpReservedFees2 { get; set; }
        public decimal ICReceiptShpReservedFees3 { get; set; }
        public decimal ICReceiptShpReservedFees4 { get; set; }
        public string ICReceiptShpMethodDesc { get; set; } = String.Empty;
        public string ICReceiptShpMethodName { get; set; } = String.Empty;
        public decimal ICReceiptShpAmt { get; set; }
        public decimal ICReceiptMiscChargeAmt { get; set; }
        public decimal ICReceiptItmPriceTot { get; set; }
        public decimal ICReceiptItmDiscAmtTot { get; set; }
        public decimal ICReceiptItmAmtTot { get; set; }
        public decimal ICReceiptTxAmtTot { get; set; }
        public decimal ICReceiptImpTxAmtTot { get; set; }
        public decimal ICReceiptNetAmtTot { get; set; }
        public decimal ICReceiptAmtTot { get; set; }
        public decimal ICReceiptCostTot { get; set; }
        public decimal ICReceiptMargPct { get; set; }
        public string ICCostAllocateType { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptRefDate { get; set; }
        public string ICReceiptShpRef { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptShpRefDate { get; set; }
        public int FK_HREmployeeID { get; set; }
        public string ICReceiptAllocateObjectTypeCombo { get; set; } = String.Empty;
        public int FK_PPWOID { get; set; }
        public string AAPostStatus { get; set; } = "New";
        public int FK_ICReceiptTypeID { get; set; }
        public Boolean ICReceiptAutoAllocateCheck { get; set; }
        public decimal ICReceiptFRAmtTot { get; set; }
        public decimal ICReceiptFAmtTot { get; set; }
        public decimal ICReceiptFImpTxAmtTot { get; set; }
        public decimal ICReceiptFTxAmtTot { get; set; }
        public decimal ICReceiptFItmAmtTot { get; set; }
        public decimal ICReceiptFItmDiscAmtTot { get; set; }
        public decimal ICReceiptFItmPriceTot { get; set; }
        public Boolean ICReceiptOnHoldCheck { get; set; }
        public int FK_PMProjectID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public string AALastPostNo { get; set; } = String.Empty;
        public Nullable<DateTime> AALastPostDate { get; set; }
        public string ICReceiptTypeCombo { get; set; } = String.Empty;
        public string APPurchaseReturnStatusCombo { get; set; } = "New";
        public string ICReceiptContractNo { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptContractDate { get; set; }
        public decimal ICReceiptItmFPriceTot { get; set; }
        public decimal ICReceiptItmDiscFAmtTot { get; set; }
        public decimal ICReceiptItmFAmtTot { get; set; }
        public decimal ICReceiptTxFAmtTot { get; set; }
        public decimal ICReceiptNetFAmtTot { get; set; }
        public decimal ICReceiptRAmtTot { get; set; }
        public decimal ICReceiptRFAmtTot { get; set; }
        public string ICCostAllocateTypeCombo { get; set; } = String.Empty;
        public int FK_ARContractID { get; set; }
        public string ICReceiptApprovalStatusCombo { get; set; } = "New";
        public string ICReceiptCarNo { get; set; } = String.Empty;
        public string ICReceiptContNo { get; set; } = String.Empty;
        public string ICReceiptSealNo { get; set; } = String.Empty;
        public string ApprovalStatusCombo { get; set; } = "New";
        public string ICReceiptInvNo { get; set; } = String.Empty;
        public string ICReceiptInvSerie { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptTimeIn { get; set; }
        public Nullable<DateTime> ICReceiptTimeOut { get; set; }
        public int FK_ICCarryTypeID { get; set; }
        public int FK_ICCarrierTeamID { get; set; }
        public string ICServiceChargeStatusCombo { get; set; } = "New";
        public Nullable<DateTime> ICServiceChargeLastdate { get; set; }
        public string ICServiceChargeLastUser { get; set; } = String.Empty;
        public Boolean ICReceiptHasPInvoiceCheck { get; set; }
        public int FK_ICShipmentID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public string ICReceiptLotNo { get; set; } = String.Empty;
        public string AACompanyTypeCombo { get; set; } = String.Empty;
        public string AAThueRemark { get; set; } = String.Empty;
        public string AAOrgDocNo { get; set; } = String.Empty;
        public int FK_PPProductionOrdrID { get; set; }
        public int FK_PPPrdQCID { get; set; }
        public int FK_APSupplierConID { get; set; }
        public string AAModule { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptJrnDate { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_GLOrgTranCfgID { get; set; }
        public int FK_APPOID { get; set; }
        public string ICPurchaseCostTypeCombo { get; set; } = String.Empty;
        public string ICReceiptJrnNo { get; set; } = String.Empty;
        public int FK_GECurrencyExObjID { get; set; }
        public int FK_ARTradeTermID { get; set; }
        public string ICReceiptPurchaseCostTypeCombo { get; set; } = String.Empty;
        public int FK_APLandedCostID { get; set; }
        public int FK_ARInvoiceID { get; set; }
        public int FK_HRMachineID { get; set; }
        public int FK_TXImpVATTaxCodeID { get; set; }
        public Nullable<DateTime> ICReceiptETDDate { get; set; }
        public Nullable<DateTime> ICReceiptETADate { get; set; }
        public Nullable<DateTime> ICReceiptReceivedDate { get; set; }
        public string ICReceiptShipperTaxNo { get; set; } = String.Empty;
        public string ICReceiptShipperAddress { get; set; } = String.Empty;
        public string ICReceiptConsigneeTaxNo { get; set; } = String.Empty;
        public string ICReceiptConsigneeAddress { get; set; } = String.Empty;
        public string ICReceiptAgentTaxNo { get; set; } = String.Empty;
        public string ICReceiptAgentAddress { get; set; } = String.Empty;
        public string ICReceiptCarrierTaxNo { get; set; } = String.Empty;
        public string ICReceiptCarrierAddress { get; set; } = String.Empty;
        public string ICReceiptPONo { get; set; } = String.Empty;
        public string ICReceiptLPortName { get; set; } = String.Empty;
        public string ICReceiptDPortName { get; set; } = String.Empty;
        public string ICReceiptConsigneeName { get; set; } = String.Empty;
        public string ICReceiptShipperName { get; set; } = String.Empty;
        public string ICReceiptAgentName { get; set; } = String.Empty;
        public string ICReceiptCarrierName { get; set; } = String.Empty;
        public int ICReceiptContQty { get; set; }
        public string ICReceiptBillLadingNo { get; set; } = String.Empty;
        public string ICReceiptCustomsNo { get; set; } = String.Empty;
        public string ICReceiptTPortName { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptCustomsDate { get; set; }
        public string ICReceiptShipName { get; set; } = String.Empty;
        public string ICReceiptTripNo { get; set; } = String.Empty;
        public string ICReceiptInvDesc { get; set; } = String.Empty;
        public Nullable<DateTime> ICReceiptInvDate { get; set; }
        public string ICReceiptDeclarationNo { get; set; } = String.Empty;
    }
}
