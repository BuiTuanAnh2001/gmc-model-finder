using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("APPurchaseReturns")]
    public class APPurchaseReturnsInfo : FixFiveProps
    {
        [Key]
        public int APPurchaseReturnID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_GEShpMthID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_ICStockID { get; set; }
        public string APSalePriceCombo { get; set; } = String.Empty;
        public string APPurchaseReturnStatusCombo { get; set; } = "New";
        public string APPurchaseReturnTypeCombo { get; set; } = String.Empty;
        public string APPurchaseReturnPmtTerm { get; set; } = String.Empty;
        public string APPmtMthCombo { get; set; } = String.Empty;
        public string APPurchaseReturnNo { get; set; } = String.Empty;
        public string APPurchaseReturnName { get; set; } = String.Empty;
        public string APPurchaseReturnDesc { get; set; } = String.Empty;
        public Boolean APPurchaseReturnOnHoldCheck { get; set; }
        public string APPurchaseReturnText { get; set; } = String.Empty;
        public Nullable<DateTime> APPurchaseReturnDate { get; set; }
        public Nullable<DateTime> APPurchaseReturnEstPmtDate { get; set; }
        public int APPurchaseReturnFiscPer { get; set; }
        public int APPurchaseReturnFiscYr { get; set; }
        public Nullable<DateTime> APPurchaseReturnShpDate { get; set; }
        public Nullable<DateTime> APPurchaseReturnExpireDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnDiscAmt { get; set; }
        public string APPurchaseReturnRef { get; set; } = String.Empty;
        public string APPurchaseReturnSupRef { get; set; } = String.Empty;
        public string APPurchaseReturnComment { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnVol { get; set; }
        public Boolean APPurchaseReturnActive { get; set; }
        public string APPurchaseReturnTxNo { get; set; } = String.Empty;
        public string APPurchaseReturnOF01Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF02Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF03Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF04Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF05Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF06Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF07Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF08Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF09Combo { get; set; } = String.Empty;
        public string APPurchaseReturnOF10Combo { get; set; } = String.Empty;
        public string APPurchaseReturnPrj { get; set; } = String.Empty;
        public string APPurchaseReturnSupplierName { get; set; } = String.Empty;
        public string APPurchaseReturnSupplierDesc { get; set; } = String.Empty;
        public int FK_APSupplierConBTID { get; set; }
        public string APPurchaseReturnBTConName { get; set; } = String.Empty;
        public string APPurchaseReturnBTConFName { get; set; } = String.Empty;
        public string APPurchaseReturnBTConLName { get; set; } = String.Empty;
        public string APPurchaseReturnBTConTitle { get; set; } = String.Empty;
        public Nullable<DateTime> APPurchaseReturnBTConBday { get; set; }
        public string APPurchaseReturnBTConHLet { get; set; } = String.Empty;
        public string APPurchaseReturnBTConHMsg { get; set; } = String.Empty;
        public string APPurchaseReturnBTConEmail { get; set; } = String.Empty;
        public string APPurchaseReturnBTConEmail11 { get; set; } = String.Empty;
        public string APPurchaseReturnBTConPhone { get; set; } = String.Empty;
        public string APPurchaseReturnBTConCPhone { get; set; } = String.Empty;
        public string APPurchaseReturnBTConFax { get; set; } = String.Empty;
        public string APPurchaseReturnBTConInfo { get; set; } = String.Empty;
        public string APPurchaseReturnBTConDept { get; set; } = String.Empty;
        public string APPurchaseReturnBTConRoom { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddL1 { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddL2 { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddL3 { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddStr { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddCity { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddPCode { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddStProv { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddZCode { get; set; } = String.Empty;
        public string APPurchaseReturnBTAddCountry { get; set; } = String.Empty;
        public int FK_APSupplierConCMID { get; set; }
        public string APPurchaseReturnCMConName { get; set; } = String.Empty;
        public string APPurchaseReturnCMConFName { get; set; } = String.Empty;
        public string APPurchaseReturnCMConLName { get; set; } = String.Empty;
        public string APPurchaseReturnCMConTitle { get; set; } = String.Empty;
        public Nullable<DateTime> APPurchaseReturnCMConBday { get; set; }
        public string APPurchaseReturnCMConHLet { get; set; } = String.Empty;
        public string APPurchaseReturnCMConHMsg { get; set; } = String.Empty;
        public string APPurchaseReturnCMConEmail { get; set; } = String.Empty;
        public string APPurchaseReturnCMConEmail1 { get; set; } = String.Empty;
        public string APPurchaseReturnCMConPhone { get; set; } = String.Empty;
        public string APPurchaseReturnCMConCPhone { get; set; } = String.Empty;
        public string APPurchaseReturnCMConFax { get; set; } = String.Empty;
        public string APPurchaseReturnCMConInfo { get; set; } = String.Empty;
        public string APPurchaseReturnCMConDept { get; set; } = String.Empty;
        public string APPurchaseReturnCMConRoom { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddL1 { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddL2 { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddL3 { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddStr { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddCity { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddPCode { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddStProv { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddZCode { get; set; } = String.Empty;
        public string APPurchaseReturnCMAddCountry { get; set; } = String.Empty;
        public int FK_APSupplierConSTID { get; set; }
        public string APPurchaseReturnSTConName { get; set; } = String.Empty;
        public string APPurchaseReturnSTConFName { get; set; } = String.Empty;
        public string APPurchaseReturnSTConLName { get; set; } = String.Empty;
        public string APPurchaseReturnSTConTitle { get; set; } = String.Empty;
        public Nullable<DateTime> APPurchaseReturnSTConBday { get; set; }
        public string APPurchaseReturnSTConHLet { get; set; } = String.Empty;
        public string APPurchaseReturnSTConHMsg { get; set; } = String.Empty;
        public string APPurchaseReturnSTConEmail { get; set; } = String.Empty;
        public string APPurchaseReturnSTConEmail1 { get; set; } = String.Empty;
        public string APPurchaseReturnSTConPhone { get; set; } = String.Empty;
        public string APPurchaseReturnSTConCPhone { get; set; } = String.Empty;
        public string APPurchaseReturnSTConFax { get; set; } = String.Empty;
        public string APPurchaseReturnSTConInfo { get; set; } = String.Empty;
        public string APPurchaseReturnSTConDept { get; set; } = String.Empty;
        public string APPurchaseReturnSTConRoom { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddL1 { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddL2 { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddL3 { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddStr { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddCity { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddPCode { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddStProv { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddZCode { get; set; } = String.Empty;
        public string APPurchaseReturnSTAddCountry { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnShpAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnItmPriceTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnItmDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnItmAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnNetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnMiscChargeAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnCostTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnMargPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnRAmtTot { get; set; }
        public string AAPostStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFRAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFImpTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFItmAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFItmDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnFItmPriceTot { get; set; }
        public string ApprovalStatusCombo { get; set; } = "New";
        public string APCreditNoteStatusCombo { get; set; } = "New";
        public string ICReceiptStatusCombo { get; set; } = "New";
        public string ICShipmentStatusCombo { get; set; } = "New";
        public Nullable<DateTime> APPurchaseReturnJrnDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPurchaseReturnExcRate { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public string APPurchaseReturnJrnNo { get; set; } = String.Empty;
        public int FK_GECurrencyExObjID { get; set; }
        public int FK_APPOID { get; set; }
        public int FK_ICReceiptID { get; set; }

    }
}