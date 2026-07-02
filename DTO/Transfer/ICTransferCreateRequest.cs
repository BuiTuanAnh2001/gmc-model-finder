using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Transfer
{
    public class ICTransferCreateRequest : FixFiveProps
    {
        public int ICTransferID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_GEShpMthID { get; set; }
        public int FK_ICFromStockID { get; set; }
        public int FK_ICToStockID { get; set; }
        public int FK_ICTransitStockID { get; set; }
        public int FK_BRBranchID { get; set; }
        public string ICTransferStatusCombo { get; set; } = "New";
        public string ICTransferTypeCombo { get; set; } = string.Empty;
        public string ICPmtMthCombo { get; set; } = string.Empty;
        public string ICTransferNo { get; set; } = string.Empty;
        public string ICTransferName { get; set; } = string.Empty;
        public string ICTransferDesc { get; set; } = string.Empty;
        public Boolean ICTransferOnHoldCheck { get; set; }
        public string ICTransferText { get; set; } = string.Empty;
        public Nullable<DateTime> ICTransferDate { get; set; }
        public int ICTransferFiscPer { get; set; }
        public int ICTransferFiscYr { get; set; }
        public Nullable<DateTime> ICTransferShpDate { get; set; }
        public Nullable<DateTime> ICTransferExpireDate { get; set; }
        public string ICTransferRef { get; set; } = string.Empty;
        public string ICTransferCusRef { get; set; } = string.Empty;
        public string ICTransferComment { get; set; } = string.Empty;
        public decimal ICTransferWeight { get; set; }
        public decimal ICTransferVol { get; set; }
        public Boolean ICTransferActive { get; set; }
        public string ICTransferTxNo { get; set; } = string.Empty;
        public decimal ICTransferExcRate { get; set; }
        public decimal ICTransferAmt { get; set; }
        public decimal ICTransferCAmt { get; set; }
        public string ICTransferOF01Combo { get; set; } = string.Empty;
        public string ICTransferOF02Combo { get; set; } = string.Empty;
        public string ICTransferOF03Combo { get; set; } = string.Empty;
        public string ICTransferOF04Combo { get; set; } = string.Empty;
        public string ICTransferOF05Combo { get; set; } = string.Empty;
        public string ICTransferOF06Combo { get; set; } = string.Empty;
        public string ICTransferOF07Combo { get; set; } = string.Empty;
        public string ICTransferOF08Combo { get; set; } = string.Empty;
        public string ICTransferOF09Combo { get; set; } = string.Empty;
        public string ICTransferOF10Combo { get; set; } = string.Empty;
        public string ICTransferPrj { get; set; } = string.Empty;
        public string ICTransferStkFConName { get; set; } = string.Empty;
        public string ICTransferStkFConFName { get; set; } = string.Empty;
        public string ICTransferStkFConLName { get; set; } = string.Empty;
        public string ICTransferStkFConTitle { get; set; } = string.Empty;
        public string ICTransferStkFConHLet { get; set; } = string.Empty;
        public string ICTransferStkFConHMsg { get; set; } = string.Empty;
        public string ICTransfeStkFConEmail { get; set; } = string.Empty;
        public string ICTransferBTConEmail1 { get; set; } = string.Empty;
        public string ICTransferStkFConPhone { get; set; } = string.Empty;
        public string ICTransferStkFConCPhone { get; set; } = string.Empty;
        public string ICTransferStkFConFax { get; set; } = string.Empty;
        public string ICTransferStkFConInfo { get; set; } = string.Empty;
        public string ICTransferStkFConDept { get; set; } = string.Empty;
        public string ICTransferStkFConRoom { get; set; } = string.Empty;
        public string ICTransferStkFAddL1 { get; set; } = string.Empty;
        public string ICTransferStkFAddL2 { get; set; } = string.Empty;
        public string ICTransferStkFAddL3 { get; set; } = string.Empty;
        public string ICTransferStkFAddStr { get; set; } = string.Empty;
        public string ICTransferStkFAddCity { get; set; } = string.Empty;
        public string ICTransferStkFAddPCode { get; set; } = string.Empty;
        public string ICTransferStkFAddStProv { get; set; } = string.Empty;
        public string ICTransferStkFAddZCode { get; set; } = string.Empty;
        public string ICTransferStkFAddCountry { get; set; } = string.Empty;
        public string ICTransferStkTrsConName { get; set; } = string.Empty;
        public Nullable<DateTime> ICTransferStkTrsConBday { get; set; }
        public string ICTransferStkTrsConFName { get; set; } = string.Empty;
        public string ICTransferStkTrsConLName { get; set; } = string.Empty;
        public string ICTransferStkTrsConTitle { get; set; } = string.Empty;
        public string ICTransferStkTrsConHLet { get; set; } = string.Empty;
        public string ICTransferStkTrsConHMsg { get; set; } = string.Empty;
        public string ICTransferStkTrsConEmail { get; set; } = string.Empty;
        public string ICTransferStkTrsConEmail1 { get; set; } = string.Empty;
        public string ICTransferStkTrsConPhone { get; set; } = string.Empty;
        public string ICTransferStkTrsConFax { get; set; } = string.Empty;
        public string ICTransferStkTrsConCPhone { get; set; } = string.Empty;
        public string ICTransferStkTrsConInfo { get; set; } = string.Empty;
        public string ICTransferStkTrsConDept { get; set; } = string.Empty;
        public string ICTransferStkTrsConRoom { get; set; } = string.Empty;
        public string ICTransferStkTrsAddL1 { get; set; } = string.Empty;
        public string ICTransferStkTrsAddL2 { get; set; } = string.Empty;
        public string ICTransferStkTrsAddL3 { get; set; } = string.Empty;
        public string ICTransferStkTrsAddStr { get; set; } = string.Empty;
        public string ICTransferStkTrsAddCity { get; set; } = string.Empty;
        public string ICTransferStkTrsAddPCode { get; set; } = string.Empty;
        public string ICTransferStkTrsAddStProv { get; set; } = string.Empty;
        public string ICTransferStkTrsAddZCode { get; set; } = string.Empty;
        public string ICTransferStkTrsAddCountry { get; set; } = string.Empty;
        public string ICTransferStkTConName { get; set; } = string.Empty;
        public Nullable<DateTime> ICTransferStkTConBday { get; set; }
        public string ICTransferStkTConFName { get; set; } = string.Empty;
        public string ICTransferStkTConLName { get; set; } = string.Empty;
        public string ICTransferStkTConTitle { get; set; } = string.Empty;
        public string ICTransferStkTConHLet { get; set; } = string.Empty;
        public string ICTransferStkTConHMsg { get; set; } = string.Empty;
        public string ICTransferStkTConEmail { get; set; } = string.Empty;
        public string ICTransferStkTConEmail1 { get; set; } = string.Empty;
        public string ICTransferStkTConPhone { get; set; } = string.Empty;
        public string ICTransferStkTConCPhone { get; set; } = string.Empty;
        public string ICTransferStkTConFax { get; set; } = string.Empty;
        public string ICTransferStkTConInfo { get; set; } = string.Empty;
        public string ICTransferStkTConDept { get; set; } = string.Empty;
        public string ICTransferStkTConRoom { get; set; } = string.Empty;
        public string ICTransferStkTAddL1 { get; set; } = string.Empty;
        public string ICTransferStkTAddL2 { get; set; } = string.Empty;
        public string ICTransferStkTAddL3 { get; set; } = string.Empty;
        public string ICTransferStkTAddStr { get; set; } = string.Empty;
        public string ICTransferStkTAddCity { get; set; } = string.Empty;
        public string ICTransferStkTAddPCode { get; set; } = string.Empty;
        public string ICTransferStkTAddStProv { get; set; } = string.Empty;
        public string ICTransferStkTAddZCode { get; set; } = string.Empty;
        public string ICTransferStkTAddCountry { get; set; } = string.Empty;
        public decimal ICTransferShpAmt { get; set; }
        public decimal ICTransferItmPriceTot { get; set; }
        public decimal ICTransferItmDiscAmtTot { get; set; }
        public decimal ICTransferItmAmtTot { get; set; }
        public decimal ICTransferTxAmtTot { get; set; }
        public decimal ICTransferNetAmtTot { get; set; }
        public decimal ICTransferAmtTot { get; set; }
        public decimal ICTransferMiscChargeAmt { get; set; }
        public decimal ICTransferCostTot { get; set; }
        public decimal ICTransferMargPct { get; set; }
        public string AAPostStatus { get; set; } = "New";
        public string AALastPostNo { get; set; } = string.Empty;
        public Nullable<DateTime> AALastPostDate { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public string ICTransferLotNo { get; set; } = string.Empty;
        public string AACompanyTypeCombo { get; set; } = string.Empty;
        public string AAThueRemark { get; set; } = string.Empty;
        public string AAOrgDocNo { get; set; } = string.Empty;
        public int FK_APSupplierID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_APSupplierConID { get; set; }
        public int FK_PPWOID { get; set; }
        public Nullable<DateTime> ICTransferJrnDate { get; set; }
        public string AAModule { get; set; } = string.Empty;
        public int FK_PPProductionOrdrID { get; set; }
        public string ICTransferJrnNo { get; set; } = string.Empty;

    }
}
