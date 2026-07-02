using gmc_api.Base.dto;
using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    [Table("APPOItems")]
    public class POItemsEntity
    {
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
        public decimal APPOItemSellFact { get; set; }
        public decimal APPOItemPackFact { get; set; }
        public decimal APPOItemUnitPrice { get; set; }
        public decimal APPOItemUnitCost { get; set; }
        public decimal APPOItemGrpDisc { get; set; }
        public decimal APPOItemDisc { get; set; }
        public decimal APPOItemTxPct { get; set; }
        public decimal APPOItemQtyOld { get; set; }
        public decimal APPOItemRQty { get; set; }
        public decimal APPOItemQty { get; set; }
        public decimal APPOItemBasicQty { get; set; }
        public decimal APPOItemPckQty { get; set; }
        public decimal APPOItemQty1 { get; set; }
        public decimal APPOItemQty2 { get; set; }
        public decimal APPOItemQty3 { get; set; }
        public decimal APPOItemQty4 { get; set; }
        public decimal APPOItemQty5 { get; set; }
        public decimal APPOItemQty6 { get; set; }
        public decimal APPOItemPrice { get; set; }
        public string APPOItemComment { get; set; } = String.Empty;
        public decimal APPOItemUnitVolumn { get; set; }
        public decimal APPOItemUnitWeight { get; set; }
        public decimal APPOItemTxAmt { get; set; }
        public decimal APPOItemDiscAmt { get; set; }
        public decimal APPOItemDiscPct { get; set; }
        public decimal APPOItemNetAmt { get; set; }
        public decimal APPOItemAmtTot { get; set; }
        public decimal APPOItemCostTot { get; set; }
        public decimal APPOItemFUnitPrice { get; set; }
        public decimal APPOItemFPrice { get; set; }
        public decimal APPOItemFTxAmt { get; set; }
        public decimal APPOItemFNetAmt { get; set; }
        public decimal APPOItemFAmtTot { get; set; }
        public decimal APPOItemFImpTxAmt { get; set; }
        public decimal APPOItemFDiscAmt { get; set; }
        public Nullable<DateTime> APPOItemArrivalDate { get; set; }
        public decimal APPOItemRcpPct { get; set; }
        public int FK_PPProductPlnItemID { get; set; }
        public int FK_PPProductPlnRMItemID { get; set; }
        public int FK_APOrdrPlnItemPOBatchID { get; set; }
        public int FK_APOrdrPlnItemPPBatchID { get; set; }
        public int FK_APSemiOrdPlanID { get; set; }
        public int FK_APSemiDetailOrdPlanID { get; set; }
        public Nullable<DateTime> APPOItemLastDate { get; set; }
        public int FK_APSupplierID { get; set; }
        public decimal APPOItemCQty { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public decimal APPOItemStkQty { get; set; }
        public decimal APPOItemRStkQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal APPOItemWTot { get; set; }
        public decimal APPOItemVTot { get; set; }
        public int FK_PPProductPlnID { get; set; }
        public int FK_ARSOID { get; set; }
        public decimal APPOItemFact { get; set; }
        public decimal APPOItemOrgQty { get; set; }
        public decimal APPOItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        public int FK_GEAnalysisID { get; set; }
        public string APPOItemOrigin { get; set; } = String.Empty;
        public string APPOItemProductNo { get; set; } = String.Empty;
        public string APPOItemProductName { get; set; } = String.Empty;
        public int FK_APPriceListID { get; set; }
        public int APPOItemPriceListCnt { get; set; }
        public decimal APPOItemReturnQty { get; set; }
        public decimal APPOItemDocRQty { get; set; }
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
        public decimal APPOItemPurchaseCostFAmt { get; set; }
        public decimal APPOItemPurchaseCostAmt { get; set; }
        public decimal APPOItemPurchaseCostUnitPrice { get; set; }
        public decimal APPOItemPurchaseCostFUnitPrice { get; set; }
        public Nullable<DateTime> APPOItemSerialDate { get; set; }
        public decimal APPOItemVirtualUnitPrice { get; set; }
        public decimal APPOItemAdjStkQty { get; set; }
        public int FK_GLBudgetCfgID { get; set; }
        public int FK_GLBudgetAllocateAdjID { get; set; }
        public int FK_GLBudgetAllocateAdjDetailID { get; set; }
        public decimal APPOItemInvQty { get; set; }
        public decimal APPOItemUsedTime { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICFGProductID { get; set; }
        public int FK_APPRID { get; set; }
        public int FK_APApprovedPriceID { get; set; }
        public int FK_TXDiffTaxCodeID { get; set; }
        public decimal APPOItemTxDiffPct { get; set; }
        public decimal APPOItemTxDiffFAmt { get; set; }
        public decimal APPOItemTxDiffAmt { get; set; }
        public decimal APPOItemTxDiffFAmtTot { get; set; }
        public decimal APPOItemTxDiffAmtTot { get; set; }
        public decimal APPOItemImpTxPct { get; set; }
        public decimal APPOItemCalcImpTaxFAmt { get; set; }
        public decimal APPOItemCalcImpTaxAmt { get; set; }
        public decimal APPOItemFImpTxAmtTot { get; set; }
        public decimal APPOItemImpTxAmtTot { get; set; }
        public decimal APPOItemFTxAmtTot { get; set; }
        public decimal APPOItemTxAmtTot { get; set; }
        public decimal APPOItemImpTxAmt { get; set; }
        public decimal APPOItemFImportCostAmt { get; set; }
        public decimal APPOItemImportCostAmt { get; set; }
        public int FK_TXImpTaxCodeID { get; set; }
        public decimal APPOItemRcpRQty { get; set; }
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
         public decimal APPOItemOrgFUnitPrice { get; set; }
        public decimal APPOItemOrgUnitPrice { get; set; }
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
        public List<APPRItemPOItemsInfo> ListAPPRItemPOItems { get; set; } = new List<APPRItemPOItemsInfo>();
        public List<APPOBOMItemsInfo> LstAPPOBOMItems { get; set; } = new List<APPOBOMItemsInfo>();
        public List<APPRItemRFQPOItemsInfo> lstAPPRItemRFQPOItems { get; set; } = new List<APPRItemRFQPOItemsInfo> { };
        public List<APPOPurchaseCostItemAllocatesInfo> lstAPPOPurchaseCostItemAllocates = new List<APPOPurchaseCostItemAllocatesInfo> { };
    }
}
