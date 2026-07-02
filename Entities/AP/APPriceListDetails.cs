using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPriceListDetails")]
    public class APPriceListDetails
    {
        [Key]
        public int APPriceListDetailID { get; set; }
        public string AAStatus { get; set; } = String.Empty;
        public Boolean AASelected { get; set; }
        public int FK_APPriceListID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public string APPriceListDetailName { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailOrgPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailProductSalePrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailProductDiscountPercent { get; set; }
        public Nullable<DateTime> APPriceListDetailFromDate { get; set; }
        public Nullable<DateTime> APPriceListDetailToDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFromQuantity { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailToQuantity { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public string APPriceListDetailSerialNo { get; set; } = String.Empty;
        public Boolean APPriceListDetailIsStkItm { get; set; }
        public string APPriceListDetailType { get; set; } = String.Empty;
        public int APPriceListDetailInvoicertOrder { get; set; }
        public string APPriceListDetailDesc { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFact { get; set; }
        public string APSalePriceCombo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailUnitCost { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailRStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFPrice { get; set; }
        public string APPriceListDetailComment { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailUnitVolumn { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailUnitWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailCostTot { get; set; }
        public string APPriceListDetailStatus { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailImpTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailImpTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailFImpTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailShpAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailMiscChargeAmt { get; set; }
        public string APPriceListDetailPurchaseReturnStatusCombo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailPurchaseReturnRQty { get; set; }
        public string APPriceListDetailAPCreditNoteStatusCombo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailAPCreditNoteRQty { get; set; }
        public string APPriceListDetailRcpNo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailAllocateLife { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailVTot { get; set; }
        public int FK_ADOFID { get; set; }
        public int FK_ADOFItemID { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ARCampaignID { get; set; }
        public string APPriceListDetailIOF01Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF02Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF03Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF04Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF05Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF06Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF07Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF08Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF09Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF10Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF11Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF12Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF13Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF14Combo { get; set; } = String.Empty;
        public string APPriceListDetailIOF15Combo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPriceListDetailOldPrice { get; set; }
    }
}
