using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ICROCreateRequest : FixFiveProps
    {
        public int ICROID { get; set; }
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
        public decimal ICSellerComAmt { get; set; }
        public decimal ICSellerComPct { get; set; }
        public string ICSalePriceCombo { get; set; } = string.Empty;
        public string ICROStatusCombo { get; set; } = "New";
        public string ICROPmtTerm { get; set; } = string.Empty;
        public decimal ICROPmtDueDays { get; set; }
        public string ICPmtMthCombo { get; set; } = string.Empty;
        public string ICRONo { get; set; } = string.Empty;
        public string ICROName { get; set; } = string.Empty;
        public string ICRODesc { get; set; } = string.Empty;
        public Boolean ICROOnHoldCheck { get; set; }
        public string ICROText { get; set; } = string.Empty;
        public Nullable<DateTime> ICRODate { get; set; }
        public int ICROFiscPer { get; set; }
        public int ICROFiscYr { get; set; }
        public Nullable<DateTime> ICROShpDate { get; set; }
        public Nullable<DateTime> ICROExpireDate { get; set; }
        public decimal ICRODiscPct { get; set; }
        public decimal ICRODiscAmt { get; set; }
        public string ICRORef { get; set; } = string.Empty;
        public string ICROCusRef { get; set; } = string.Empty;
        public string ICROComment { get; set; } = string.Empty;
        public decimal ICROWeight { get; set; }
        public decimal ICROVol { get; set; }
        public Boolean ICROActive { get; set; }
        public string ICROTxNo { get; set; } = string.Empty;
        public decimal ICROExcRate { get; set; }
        public decimal ICROAmt { get; set; }
        public decimal ICROCAmt { get; set; }
        public string ICROSubType { get; set; } = string.Empty;
        public string ICROOF01Combo { get; set; } = string.Empty;
        public string ICROOF02Combo { get; set; } = string.Empty;
        public string ICROOF03Combo { get; set; } = string.Empty;
        public string ICROOF04Combo { get; set; } = string.Empty;
        public string ICROOF05Combo { get; set; } = string.Empty;
        public string ICROOF06Combo { get; set; } = string.Empty;
        public string ICROOF07Combo { get; set; } = string.Empty;
        public string ICROOF08Combo { get; set; } = string.Empty;
        public string ICROOF09Combo { get; set; } = string.Empty;
        public string ICROOF10Combo { get; set; } = string.Empty;
        public string ICROPrj { get; set; } = string.Empty;
        public string ICROCustomerName { get; set; } = string.Empty;
        public string ICROCustomerDesc { get; set; } = string.Empty;
        public int FK_ARCustomerConBTID { get; set; }
        public string ICROBTConName { get; set; } = string.Empty;
        public string ICROBTConFName { get; set; } = string.Empty;
        public string ICROBTConLName { get; set; } = string.Empty;
        public string ICROBTConTitle { get; set; } = string.Empty;
        public string ICROBTConHLet { get; set; } = string.Empty;
        public string ICROBTConHMsg { get; set; } = string.Empty;
        public string ICROBTConEmail { get; set; } = string.Empty;
        public string ICROBTConEmail1 { get; set; } = string.Empty;
        public string ICROBTConPhone { get; set; } = string.Empty;
        public string ICROBTConCPhone { get; set; } = string.Empty;
        public string ICROBTConFax { get; set; } = string.Empty;
        public string ICROBTConInfo { get; set; } = string.Empty;
        public string ICROBTConDept { get; set; } = string.Empty;
        public string ICROBTConRoom { get; set; } = string.Empty;
        public string ICROBTAddL1 { get; set; } = string.Empty;
        public string ICROBTAddL2 { get; set; } = string.Empty;
        public string ICROBTAddL3 { get; set; } = string.Empty;
        public string ICROBTAddStr { get; set; } = string.Empty;
        public string ICROBTAddCity { get; set; } = string.Empty;
        public string ICROBTAddPCode { get; set; } = string.Empty;
        public string ICROBTAddStProv { get; set; } = string.Empty;
        public string ICROBTAddZCode { get; set; } = string.Empty;
        public string ICROBTAddCountry { get; set; } = string.Empty;
        public int FK_ARCustomerConCMID { get; set; }
        public string ICROCMConName { get; set; } = string.Empty;
        public Nullable<DateTime> ICROCMConBday { get; set; }
        public string ICROCMConFName { get; set; } = string.Empty;
        public string ICROCMConLName { get; set; } = string.Empty;
        public string ICROCMConTitle { get; set; } = string.Empty;
        public string ICROCMConHLet { get; set; } = string.Empty;
        public string ICROCMConHMsg { get; set; } = string.Empty;
        public string ICROCMConEmail { get; set; } = string.Empty;
        public string ICROCMConEmail1 { get; set; } = string.Empty;
        public string ICROCMConPhone { get; set; } = string.Empty;
        public string ICROCMConCPhone { get; set; } = string.Empty;
        public string ICROCMConFax { get; set; } = string.Empty;
        public string ICROCMConInfo { get; set; } = string.Empty;
        public string ICROCMConDept { get; set; } = string.Empty;
        public string ICROCMConRoom { get; set; } = string.Empty;
        public string ICROCMAddL1 { get; set; } = string.Empty;
        public string ICROCMAddL2 { get; set; } = string.Empty;
        public string ICROCMAddL3 { get; set; } = string.Empty;
        public string ICROCMAddStr { get; set; } = string.Empty;
        public string ICROCMAddCity { get; set; } = string.Empty;
        public string ICROCMAddPCode { get; set; } = string.Empty;
        public string ICROCMAddStProv { get; set; } = string.Empty;
        public string ICROCMAddZCode { get; set; } = string.Empty;
        public string ICROCMAddCountry { get; set; } = string.Empty;
        public int FK_ARCustomerConSTID { get; set; }
        public string ICROSTConName { get; set; } = string.Empty;
        public Nullable<DateTime> ICROSTConBday { get; set; }
        public string ICROSTConFName { get; set; } = string.Empty;
        public string ICROSTConLName { get; set; } = string.Empty;
        public string ICROSTConTitle { get; set; } = string.Empty;
        public string ICROSTConHLet { get; set; } = string.Empty;
        public string ICROSTConHMsg { get; set; } = string.Empty;
        public string ICROSTConEmail { get; set; } = string.Empty;
        public string ICROSTConEmail1 { get; set; } = string.Empty;
        public string ICROSTConPhone { get; set; } = string.Empty;
        public string ICROSTConCPhone { get; set; } = string.Empty;
        public string ICROSTConFax { get; set; } = string.Empty;
        public string ICROSTConInfo { get; set; } = string.Empty;
        public string ICROSTConDept { get; set; } = string.Empty;
        public string ICROSTConRoom { get; set; } = string.Empty;
        public string ICROSTAddL1 { get; set; } = string.Empty;
        public string ICROSTAddL2 { get; set; } = string.Empty;
        public string ICROSTAddL3 { get; set; } = string.Empty;
        public string ICROSTAddStr { get; set; } = string.Empty;
        public string ICROSTAddCity { get; set; } = string.Empty;
        public string ICROSTAddPCode { get; set; } = string.Empty;
        public string ICROSTAddStProv { get; set; } = string.Empty;
        public string ICROSTAddZCode { get; set; } = string.Empty;
        public string ICROSTAddCountry { get; set; } = string.Empty;
        public decimal ICROShpAmt { get; set; }
        public decimal ICROItmPriceTot { get; set; }
        public decimal ICROItmDiscAmtTot { get; set; }
        public decimal ICROItmAmtTot { get; set; }
        public decimal ICROTxAmtTot { get; set; }
        public decimal ICRONetAmtTot { get; set; }
        public decimal ICROAmtTot { get; set; }
        public decimal ICROMiscChargeAmt { get; set; }
        public decimal ICROCostTot { get; set; }
        public decimal ICROMargPct { get; set; }
        public string ICROStatus { get; set; } = "New";
        public Nullable<DateTime> ICROHoldDate { get; set; }
        public Nullable<DateTime> ICROHoldBy { get; set; }
        public int ICROHoldTot { get; set; }
        public decimal ICROWCapTot { get; set; }
        public decimal ICROVCapTot { get; set; }
        public decimal ICRODistance { get; set; }
        public int FK_PPWOID { get; set; }
        public string AAPostStatus { get; set; } = "New";
        public int FK_HRDepartmentID { get; set; }
        public string ICROEquipmentTypeCombo { get; set; } = string.Empty;
        public int FK_ICROTypeID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public decimal ICRORAmtTot { get; set; }
        public Boolean ICROAutoCreateWarantyCheck { get; set; }
        public decimal ICROFRAmtTot { get; set; }
        public decimal ICROFAmtTot { get; set; }
        public decimal ICROFImpTxAmtTot { get; set; }
        public decimal ICROFTxAmtTot { get; set; }
        public decimal ICROFItmAmtTot { get; set; }
        public decimal ICROFItmDiscAmtTot { get; set; }
        public decimal ICROFItmPriceTot { get; set; }
        public int FK_PMProjectID { get; set; }
        public string AALastPostNo { get; set; } = string.Empty;
        public Nullable<DateTime> AALastPostDate { get; set; }
        public string ICROWarantyStatus { get; set; } = "New";
        public string ICROTypeCombo { get; set; } = string.Empty;
        public string SaleReturnStatusCombo { get; set; } = "New";
        public decimal ICRODiscFAmt { get; set; }
        public decimal ICRODriverPmtAmtTot { get; set; }
        public decimal ICROItmFPriceTot { get; set; }
        public decimal ICROItmDiscFAmtTot { get; set; }
        public decimal ICROItmFAmtTot { get; set; }
        public decimal ICROTxFAmtTot { get; set; }
        public decimal ICRONetFAmtTot { get; set; }
        public decimal ICRORFAmtTot { get; set; }
        public int FK_ARContractID { get; set; }
        public string ICROApprovalStatusCombo { get; set; } = "New";
        public string ICROCarNo { get; set; } = string.Empty;
        public string ICROContNo { get; set; } = string.Empty;
        public string ICROSealNo { get; set; } = string.Empty;
        public string ApprovalStatusCombo { get; set; } = "New";
        public Nullable<DateTime> ICROTimeIn { get; set; }
        public Nullable<DateTime> ICROTimeOut { get; set; }
        public int FK_ICCarryTypeID { get; set; }
        public int FK_ICCarrierTeamID { get; set; }
        public string ICROInvNo { get; set; } = string.Empty;
        public string ICServiceChargeStatusCombo { get; set; } = "New";
        public Nullable<DateTime> ICServiceChargeLastdate { get; set; }
        public string ICServiceChargeLastUser { get; set; } = string.Empty;
        public string ICROVoucherRefNo { get; set; } = string.Empty;
        public string APPurchaseReturnStatusCombo { get; set; } = "New";
        public int FK_ARCustomerOwnerID { get; set; }
        public int FK_LOPortPOLID { get; set; }
        public int FK_LOPortPODID { get; set; }
        public Nullable<DateTime> ICROETDDate { get; set; }
        public Nullable<DateTime> ICROETADate { get; set; }
        public Nullable<DateTime> ICROReceivedDate { get; set; }
        public int FK_ARShipperID { get; set; }
        public string ICROShipperTaxNo { get; set; } = string.Empty;
        public string ICROShipperAddress { get; set; } = string.Empty;
        public int FK_ARConsigneeID { get; set; }
        public string ICROConsigneeTaxNo { get; set; } = string.Empty;
        public string ICROConsigneeAddress { get; set; } = string.Empty;
        public int FK_LOAgentID { get; set; }
        public string ICROAgentTaxNo { get; set; } = string.Empty;
        public string ICROAgentAddress { get; set; } = string.Empty;
        public int FK_LOCarrierID { get; set; }
        public string ICROCarrierTaxNo { get; set; } = string.Empty;
        public string ICROCarrierAddress { get; set; } = string.Empty;
        public string ICROPONo { get; set; } = string.Empty;
        public int FK_GLTranCfgID { get; set; }
        public string ICROLPortName { get; set; } = string.Empty;
        public string ICRODPortName { get; set; } = string.Empty;
        public string ICROConsigneeName { get; set; } = string.Empty;
        public string ICROShipperName { get; set; } = string.Empty;
        public string ICROAgentName { get; set; } = string.Empty;
        public string ICROCarrierName { get; set; } = string.Empty;
        public int FK_LOConsigneeID { get; set; }
        public string ICROTransferStatusCombo { get; set; } = "New";
        public int FK_APPOID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public string AAModule { get; set; } = string.Empty;
        public string ICROSupAdd { get; set; } = string.Empty;
        public string ICROOptional01 { get; set; } = string.Empty;
        public string ICROOptional02 { get; set; } = string.Empty;
        public string ICROOptional03 { get; set; } = string.Empty;
        public int FK_ARTradeTermID { get; set; }
        public int FK_GECurrencyExObjID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_GEIncoTermID { get; set; }
        public string ICRODestination { get; set; } = string.Empty;
        public int ICROExportCount { get; set; }
        public string ICROExportStatus { get; set; } = "New";
        public int FK_GLOrgTranCfgID { get; set; }
        public string ICROOF11Combo { get; set; } = string.Empty;
        public string ICROOF12Combo { get; set; } = string.Empty;
        public string ICROOF13Combo { get; set; } = string.Empty;
        public string ICROOF14Combo { get; set; } = string.Empty;
        public string ICROOF15Combo { get; set; } = string.Empty;
        public string ICROCStatusCombo { get; set; } = "New";
        public decimal ICROActPrice { get; set; }
        public decimal ICROTotalPkgCBM { get; set; }
        public int FK_ARShpPlanID { get; set; }
        public string ICROLCNo { get; set; } = string.Empty;
        public Nullable<DateTime> ICRODueTime { get; set; }
        public decimal ICROContQty { get; set; }
        public string ICROBillLadingNo { get; set; } = string.Empty;
        public string ICROCustomsNo { get; set; } = string.Empty;
        public string ICROTPortName { get; set; } = string.Empty;
        public Nullable<DateTime> ICROCustomsDate { get; set; }
        public string ICROShipName { get; set; } = string.Empty;
        public string ICROTripNo { get; set; } = string.Empty;
        public string ICROExportStatusCombo { get; set; } = "New";
        public string ICROBooking { get; set; } = string.Empty;
        public int FK_ADApprovalProcID { get; set; }

    }
}
