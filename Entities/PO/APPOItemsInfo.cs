using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPOItems")]
    public class APPOItemsInfo
    {
        [Key]
        public int APPOItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public string APPOItemStatus { get; set; } = "New";
        public int FK_APPOID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public string APPOItemSerialNo { get; set; } = String.Empty;
        public Boolean APPOItemIsStkItm { get; set; }
        public string APPOItemType { get; set; } = String.Empty;
        public int APPOItemSrtOrder { get; set; }
        public string APPOItemDesc { get; set; } = String.Empty;
        public string APPOItemSellUnit { get; set; } = String.Empty;
        public string APPOItemBasicUnit { get; set; } = String.Empty;
        public string APPOItemPackUnit { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemSellFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPackFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemUnitCost { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemGrpDisc { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemDisc { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQtyOld { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemBasicQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPckQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty1 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty2 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty3 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty4 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty5 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemQty6 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPrice { get; set; }
        public string APPOItemComment { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemUnitVolumn { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemUnitWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemCostTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFImpTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFDiscAmt { get; set; }
        public Nullable<DateTime> APPOItemArrivalDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemRcpPct { get; set; }
        public int FK_PPProductPlnItemID { get; set; }
        public int FK_PPProductPlnRMItemID { get; set; }
        public int FK_APOrdrPlnItemPOBatchID { get; set; }
        public int FK_APOrdrPlnItemPPBatchID { get; set; }
        public int FK_APSemiOrdPlanID { get; set; }
        public int FK_APSemiDetailOrdPlanID { get; set; }
        public Nullable<DateTime> APPOItemLastDate { get; set; }
        public int FK_APSupplierID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemCQty { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemRStkQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemVTot { get; set; }
        public int FK_PPProductPlnID { get; set; }
        public int FK_ARSOID { get; set; }
        [Column(TypeName = "decimal(19, 12)")] public decimal APPOItemFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemOrgQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        public int FK_GEAnalysisID { get; set; }
        public string APPOItemOrigin { get; set; } = String.Empty;
        public string APPOItemProductNo { get; set; } = String.Empty;
        public string APPOItemProductName { get; set; } = String.Empty;
        public int FK_APPriceListID { get; set; }
        public int APPOItemPriceListCnt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemReturnQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemDocRQty { get; set; }
        public int FK_APPriceListDetailID { get; set; }
        public int FK_APPOItemID { get; set; }
        public int FK_FAAssetConstructionID { get; set; }
        public int FK_FAAssetID { get; set; }
        public string GLTOF01Combo { get; set; } = String.Empty;
        public string GLTOF02Combo { get; set; } = String.Empty;
        public string GLTOF03Combo { get; set; } = String.Empty;
        public string GLTOF04Combo { get; set; } = String.Empty;
        public string GLTOF05Combo { get; set; } = String.Empty;
        public string GLTOF06Combo { get; set; } = String.Empty;
        public string GLTOF07Combo { get; set; } = String.Empty;
        public string GLTOF08Combo { get; set; } = String.Empty;
        public string GLTOF09Combo { get; set; } = String.Empty;
        public string GLTOF10Combo { get; set; } = String.Empty;
        public string GLTOF11Combo { get; set; } = String.Empty;
        public string GLTOF12Combo { get; set; } = String.Empty;
        public string GLTOF13Combo { get; set; } = String.Empty;
        public string GLTOF14Combo { get; set; } = String.Empty;
        public string GLTOF15Combo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPurchaseCostFAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPurchaseCostAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPurchaseCostUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemPurchaseCostFUnitPrice { get; set; }
        public Nullable<DateTime> APPOItemSerialDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemVirtualUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemAdjStkQty { get; set; }
        public int FK_GLBudgetCfgID { get; set; }
        public int FK_GLBudgetAllocateAdjID { get; set; }
        public int FK_GLBudgetAllocateAdjDetailID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemInvQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemUsedTime { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICFGProductID { get; set; }
        public int FK_APPRID { get; set; }
        public int FK_APApprovedPriceID { get; set; }
        public int FK_TXDiffTaxCodeID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxDiffPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxDiffFAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxDiffAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxDiffFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxDiffAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemImpTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemCalcImpTaxFAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemCalcImpTaxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFImpTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemImpTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemTxAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemImpTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemFImportCostAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemImportCostAmt { get; set; }
        public int FK_TXImpTaxCodeID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemRcpRQty { get; set; }
        public int FK_PPWOMRPID { get; set; }
        public int FK_PPWOMRPItemID { get; set; }
        public int FK_PPWOEstFGItemID { get; set; }
        public string APPOItemFGLotNo { get; set; } = String.Empty;
        public string APPOItemDesc1 { get; set; } = String.Empty;
        public string APPOItemLotNo { get; set; } = String.Empty;
        public Nullable<DateTime> APPOItemExpireDate { get; set; }
        public string APPOItemPOF01Combo { get; set; } = String.Empty;
        public string APPOItemPOF02Combo { get; set; } = String.Empty;
        public string APPOItemPOF03Combo { get; set; } = String.Empty;
        public string APPOItemPOF04Combo { get; set; } = String.Empty;
        public string APPOItemPOF05Combo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemOrgFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPOItemOrgUnitPrice { get; set; }
        public int FK_PPMaterialPlanID { get; set; }
        public int FK_PPPlanProductionRMID { get; set; }
        public string GLTOF16Combo { get; set; } = String.Empty;
        public string GLTOF17Combo { get; set; } = String.Empty;
        public string GLTOF18Combo { get; set; } = String.Empty;
        public string GLTOF19Combo { get; set; } = String.Empty;
        public string GLTOF20Combo { get; set; } = String.Empty;
        public string GLTOF21Combo { get; set; } = String.Empty;
        public string GLTOF22Combo { get; set; } = String.Empty;
        public string GLTOF23Combo { get; set; } = String.Empty;
        public string GLTOF24Combo { get; set; } = String.Empty;
        public string GLTOF25Combo { get; set; } = String.Empty;
        public string GLTOF26Combo { get; set; } = String.Empty;
        public string GLTOF27Combo { get; set; } = String.Empty;
        public string GLTOF28Combo { get; set; } = String.Empty;
        public string GLTOF29Combo { get; set; } = String.Empty;
        public string GLTOF30Combo { get; set; } = String.Empty;
        public string GLTOF31Combo { get; set; } = String.Empty;
        public string GLTOF32Combo { get; set; } = String.Empty;
        public string GLTOF33Combo { get; set; } = String.Empty;
        public string GLTOF34Combo { get; set; } = String.Empty;
        public string GLTOF35Combo { get; set; } = String.Empty;
        public int FK_PPMRPItemID { get; set; }
    }
}
