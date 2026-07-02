using System;

namespace gmc_api.DTO.IC
{
    public class ICReceiptItemCreateRequest
    {
        public int ICReceiptItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_ICReceiptID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public string ICReceiptItemSerialNo { get; set; } = String.Empty;
        public string ICReceiptItemType { get; set; } = String.Empty;
        public Boolean ICReceiptItemIsStkItm { get; set; }
        public string ICReceiptItemDesc { get; set; } = String.Empty;
        public decimal ICReceiptItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = String.Empty;
        public decimal ICReceiptItemUnitPrice { get; set; }
        public decimal ICReceiptItemUnitCost { get; set; }
        public decimal ICReceiptItemDiscPct { get; set; }
        public decimal ICReceiptItemTxPct { get; set; }
        public decimal ICReceiptItemVolume { get; set; }
        public decimal ICReceiptItemQty { get; set; }
        public decimal ICReceiptItemStkQty { get; set; }
        public decimal ICReceiptItemRQty { get; set; }
        public decimal ICReceiptItemRStkQty { get; set; }
        public decimal ICReceiptItemPrice { get; set; }
        public string ICReceiptItemComment { get; set; } = String.Empty;
        public decimal ICReceiptItemUnitVol { get; set; }
        public decimal ICReceiptItemUnitWeight { get; set; }
        public decimal ICReceiptItemTxAmt { get; set; }
        public decimal ICReceiptItemDiscAmt { get; set; }
        public decimal ICReceiptItemNetAmt { get; set; }
        public decimal ICReceiptItemAmtTot { get; set; }
        public decimal ICReceiptItemDirectCostTot { get; set; }
        public decimal ICReceiptItemInDirectCostTot { get; set; }
        public decimal ICReceiptItemInDirectAllocateCostTot { get; set; }
        public decimal ICReceiptItemCostTot { get; set; }
        public string ICReceiptItemStatus { get; set; } = "New";
        public decimal ICReceiptItemAmt { get; set; }
        public decimal ICReceiptItemCAmt { get; set; }
        public decimal ICReceiptItemShpAmt { get; set; }
        public decimal ICReceiptItemMiscChargeAmt { get; set; }
        public decimal ICReceiptItemImpTxAmt { get; set; }
        public int FK_TXImpTaxCodeID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICProductIDWO { get; set; }
        public Nullable<DateTime> ICReceiptItemExpiredDate { get; set; }
        public Nullable<DateTime> ICReceiptItemDate { get; set; }
        public decimal ICReceiptItemShpQty { get; set; }
        public decimal ICReceiptItemShpRQty { get; set; }
        public int FK_ICProductParentID { get; set; }
        public decimal ICReceiptItemFUnitPrice { get; set; }
        public decimal ICReceiptItemFPrice { get; set; }
        public decimal ICReceiptItemFTxAmt { get; set; }
        public decimal ICReceiptItemFNetAmt { get; set; }
        public decimal ICReceiptItemFAmtTot { get; set; }
        public decimal ICReceiptItemFImpTxAmt { get; set; }
        public Nullable<DateTime> ICReceiptItemExpireDate { get; set; }
        public int FK_GLDebitAccountID { get; set; }
        public int FK_GLCreditAccountID { get; set; }
        public int FK_GLDebitVATAccountID { get; set; }
        public int FK_GLCreditVATAccountID { get; set; }
        public string ICReceiptItemPurchaseReturnStatusCombo { get; set; } = "New";
        public decimal ICReceiptItemPurchaseReturnRQty { get; set; }
        public string ICReceiptItemLotNo { get; set; } = String.Empty;
        public decimal ICReceiptItemFreightAmt { get; set; }
        public decimal ICReceiptItemSealedBankQty { get; set; }
        public decimal ICReceiptItemSealedBankRQty { get; set; }
        public int FK_ARLendContractID { get; set; }
        public int FK_ICStockUOMID { get; set; }
        public decimal ICReceiptItemAllocateQty { get; set; }
        public decimal ICReceiptItemPOQty { get; set; }
        public decimal ICReceiptItemPOReceiptQty { get; set; }
        public decimal ICReceiptItemPORQty { get; set; }
        public string ICPackageLockTypeCombo { get; set; } = String.Empty;
        public Boolean ICReceiptItemIsCostingItemCheck { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public decimal ICReceiptItemHeight { get; set; }
        public decimal ICReceiptItemWidth { get; set; }
        public decimal ICReceiptItemLength { get; set; }
        public string ICReceiptItemProductionTypeCombo { get; set; } = String.Empty;
        public int FK_GLCostDistID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_PPWOID { get; set; }
        public decimal ICReceiptItemOverheadCost { get; set; }
        public decimal ICReceiptItemLaborCost { get; set; }
        public decimal ICReceiptItemBeginCostAmt { get; set; }
        public decimal ICReceiptItemIndirectRMCost { get; set; }
        public int FK_PPRoutingID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal ICReceiptItemWTot { get; set; }
        public decimal ICReceiptItemVTot { get; set; }
        public decimal ICReceiptItemOrgQty { get; set; }
        public decimal ICReceiptItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        public decimal ICReceiptItemCQty { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public int FK_ICAssemblyID { get; set; }
        public int FK_ICKitID { get; set; }
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
        public string ICReceiptItemProductNo { get; set; } = String.Empty;
        public string ICReceiptItemProductName { get; set; } = String.Empty;
        public decimal ICReceiptItemImportCostAmt { get; set; }
        public decimal ICReceiptItemFImportCostAmt { get; set; }
        public int FK_ICShipmentItemID { get; set; }
        public int FK_PPNormID { get; set; }
        public int FK_ARInvoiceItemID { get; set; }
        public int FK_ParentPPProductionOrdrID { get; set; }
        public string GLTOF11Combo { get; set; } = String.Empty;
        public string GLTOF12Combo { get; set; } = String.Empty;
        public string GLTOF13Combo { get; set; } = String.Empty;
        public string GLTOF14Combo { get; set; } = String.Empty;
        public string GLTOF15Combo { get; set; } = String.Empty;
        public int FK_APPOItemID { get; set; }
        public int FK_APPOID { get; set; }
        public int FK_FAAssetID { get; set; }
        public int FK_FAAssetConstructionID { get; set; }
        public int FK_APSupplierID { get; set; }
        public string ICReceiptItemAllocateTypeCombo { get; set; } = String.Empty;
        public int FK_ICReceiptItemTaxImportID { get; set; }
        public int FK_ARCampaignID { get; set; }
        public int FK_ICReceiptItemID { get; set; }
        public decimal ICReceiptItemAdjStkQty { get; set; }
        public decimal ICReceiptItemAdjUnitPricePct01 { get; set; }
        public decimal ICReceiptItemAdjUnitPricePct02 { get; set; }
        public decimal ICReceiptItemAdjUnitPricePct03 { get; set; }
        public decimal ICReceiptItemAdjUnitPricePct04 { get; set; }
        public decimal ICReceiptItemAdjUnitPricePct05 { get; set; }
        public decimal ICReceiptItemAdjDiscPct01 { get; set; }
        public decimal ICReceiptItemAdjDiscPct02 { get; set; }
        public decimal ICReceiptItemAdjDiscPct03 { get; set; }
        public decimal ICReceiptItemAdjDiscPct04 { get; set; }
        public decimal ICReceiptItemAdjDiscPct05 { get; set; }
        public decimal ICReceiptItemAdjDiscFAmt01 { get; set; }
        public decimal ICReceiptItemAdjDiscFAmt02 { get; set; }
        public decimal ICReceiptItemAdjDiscFAmt03 { get; set; }
        public decimal ICReceiptItemAdjDiscFAmt04 { get; set; }
        public decimal ICReceiptItemAdjDiscFAmt05 { get; set; }
        public decimal ICReceiptItemAdjDiscAmt01 { get; set; }
        public decimal ICReceiptItemAdjDiscAmt02 { get; set; }
        public decimal ICReceiptItemAdjDiscAmt03 { get; set; }
        public decimal ICReceiptItemAdjDiscAmt04 { get; set; }
        public decimal ICReceiptItemAdjDiscAmt05 { get; set; }
        public decimal ICReceiptItemNetAmtTot { get; set; }
        public decimal ICReceiptItemFNetAmtTot { get; set; }
        public int FK_GLBudgetID { get; set; }
        public int FK_GLBudgetCfgID { get; set; }
        public int FK_GLBudgetAllocateAdjID { get; set; }
        public int FK_GLBudgetAllocateAdjItemID { get; set; }
        public int FK_GLBudgetAllocateAdjDetailID { get; set; }
        public decimal ICReceiptItemDiscAmtTot { get; set; }
        public decimal ICReceiptItemFDiscAmtTot { get; set; }
        public decimal ICReceiptItemFDiscAmt { get; set; }
        public string ICReceiptItemParentLotNo { get; set; } = String.Empty;
        public decimal ICReceiptItemLaboQty { get; set; }
        public decimal ICReceiptItemMachineTimeQty { get; set; }
        public decimal ICReceiptItemMeritTimeQty { get; set; }
        public string ICReceiptItemFGLotNo { get; set; } = String.Empty;
        public Boolean ICReceiptItemIsAVGCost { get; set; }
        public Nullable<DateTime> ICReceiptItemShpDate { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_PPProductionOrdrEstFGID { get; set; }
        public Nullable<DateTime> ICReceiptItemStarTime { get; set; }
        public Nullable<DateTime> ICReceiptItemEndTime { get; set; }
        public decimal ICReceiptItemDownTimeQty { get; set; }
        public int FK_TXDiffTaxCodeID { get; set; }
        public decimal ICReceiptItemTxDiffPct { get; set; }
        public decimal ICReceiptItemTxDiffFAmt { get; set; }
        public decimal ICReceiptItemTxDiffAmt { get; set; }
        public decimal ICReceiptItemTxDiffFAmtTot { get; set; }
        public decimal ICReceiptItemTxDiffAmtTot { get; set; }
        public decimal ICReceiptItemImpTxPct { get; set; }
        public decimal ICReceiptItemCalcImpTaxFAmt { get; set; }
        public decimal ICReceiptItemCalcImpTaxAmt { get; set; }
        public decimal ICReceiptItemFImpTxAmtTot { get; set; }
        public decimal ICReceiptItemImpTxAmtTot { get; set; }
        public decimal ICReceiptItemFTxAmtTot { get; set; }
        public decimal ICReceiptItemTxAmtTot { get; set; }
        public int FK_ICProductRootID { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_PPWOPItemID { get; set; }
        public byte[] ICReceiptItemBarCode { get; set; }
        public string ICReceiptItemBarCodeNo { get; set; } = String.Empty;
        public decimal ICReceiptItemPrintQty { get; set; }
        public string ICReceiptItemDesc2 { get; set; } = String.Empty;
        public string ICReceiptItemPONumber { get; set; } = String.Empty;
        public decimal ICReceiptItemPurchaseExchangeRQty { get; set; }
        public bool ICReceiptItemQCNotPass { get; set; }
        public string ICReceiptItemQCDesc { get; set; } = String.Empty;
        public decimal ICReceiptItemNCRQty { get; set; }
        public bool ICReceiptItemIsIdentifyCost { get; set; }
    }
}
