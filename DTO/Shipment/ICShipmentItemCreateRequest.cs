using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Shipment
{
    public class ICShipmentItemCreateRequest
    {
        public int ICShipmentItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; } = true;
        public int FK_ICShipmentID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARInvoiceID { get; set; }
        public string ICShipmentItemSerialNo { get; set; } = string.Empty;
        public string ICShipmentItemType { get; set; } = string.Empty;
        public Boolean ICShipmentItemIsStkItm { get; set; }
        public string ICShipmentItemDesc { get; set; } = string.Empty;
        public string ICShipmentItemPkgUOM { get; set; } = string.Empty;
        public decimal ICShipmentItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = string.Empty;
        public decimal ICShipmentItemUnitPrice { get; set; }
        public decimal ICShipmentItemUnitCost { get; set; }
        public decimal ICShipmentItemDiscPct { get; set; }
        public decimal ICShipmentItemTxPct { get; set; }
        public decimal ICShipmentItemVolume { get; set; }
        public decimal ICShipmentItemQty { get; set; }
        public decimal ICShipmentItemPkgQty { get; set; }
        public decimal ICShipmentItemStkQty { get; set; }
        public decimal ICShipmentItemRQty { get; set; }
        public decimal ICShipmentItemRStkQty { get; set; }
        public decimal ICShipmentItemPrice { get; set; }
        public string ICShipmentItemComment { get; set; } = string.Empty;
        public decimal ICShipmentItemUnitVol { get; set; }
        public decimal ICShipmentItemUnitWeight { get; set; }
        public decimal ICShipmentItemTxAmt { get; set; }
        public decimal ICShipmentItemDiscAmt { get; set; }
        public decimal ICShipmentItemNetAmt { get; set; }
        public decimal ICShipmentItemAmtTot { get; set; }
        public decimal ICShipmentItemCostTot { get; set; }
        public string ICShipmentItemStatus { get; set; } = "New";
        public decimal ICShipmentItemAmt { get; set; }
        public decimal ICShipmentItemCAmt { get; set; }
        public decimal ICShipmentItemWTot { get; set; }
        public decimal ICShipmentItemVTot { get; set; }
        public int FK_LOShpPlanID { get; set; }
        public int ICShipmentItemSortOrder { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICProductIDWO { get; set; }
        public int FK_HRDerpamentID { get; set; }
        public int FK_ICReceiptItemID { get; set; }
        public Nullable<DateTime> ICShipmentItemExpireDate { get; set; }
        public int FK_ICProductParentID { get; set; }
        public decimal ICShipmentItemFUnitPrice { get; set; }
        public decimal ICShipmentItemFPrice { get; set; }
        public decimal ICShipmentItemFTxAmt { get; set; }
        public decimal ICShipmentItemFNetAmt { get; set; }
        public decimal ICShipmentItemFAmtTot { get; set; }
        public decimal ICShipmentItemFImpTxAmt { get; set; }
        public int FK_GLDebitAccountID { get; set; }
        public int FK_GLCreditAccountID { get; set; }
        public int FK_GLDebitVATAccountID { get; set; }
        public int FK_GLCreditVATAccountID { get; set; }
        public decimal ICShipmentItemAllocateLife { get; set; }
        public int FK_FAAssetID { get; set; }
        public int FK_HRDepartmentID { get; set; }
        public decimal ICShipmentItemAssetLife { get; set; }
        public int FK_ARCampaignID { get; set; }
        public int FK_ARCampaignItemID { get; set; }
        public int FK_ARCreditNoteItemID { get; set; }
        public decimal ICShipmentItemSaleReturnRQty { get; set; }
        public string ICShipmentItemSaleReturnStatusCombo { get; set; } = string.Empty;
        public string ICShipmentItemLotNo { get; set; } = string.Empty;
        public decimal APSOItemFUnitPrice { get; set; }
        public decimal ICShipmentItemDriverPmtAmt { get; set; }
        public decimal ICShipmentItemDriverPmtPct { get; set; }
        public Boolean ICShipmentItemIsValidInv { get; set; }
        public decimal ICShipmentItemAllocateQty { get; set; }
        public decimal ICShipmentItemRequestQty { get; set; }
        public string ICPackageLockTypeCombo { get; set; }
        public decimal ICShipmentItemPurchaseReturnRQty { get; set; }
        public string ICShipmentItemPurchaseReturnStatusCombo { get; set; }
        public Boolean ICShipmentItemIsCostingItemCheck { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public int FK_GLCostDistID { get; set; }
        public int FK_ICDistributionRuleID { get; set; }
        public int FK_PPPkgOrderItemID { get; set; }
        public int FK_GLCostCenterID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_PPWOID { get; set; }
        public Boolean ICShipmentItemIsIdentifyCost { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICPkgUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal ICShipmentItemOrgQty { get; set; }
        public decimal ICShipmentItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        public decimal ICShipmentItemCQty { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public int FK_ICAssemblyID { get; set; }
        public int FK_ICKitID { get; set; }
        public string GLTOF01Combo { get; set; } = string.Empty;
        public string GLTOF02Combo { get; set; } = string.Empty;
        public string GLTOF03Combo { get; set; } = string.Empty;
        public string GLTOF04Combo { get; set; } = string.Empty;
        public string GLTOF05Combo { get; set; } = string.Empty;
        public string GLTOF06Combo { get; set; } = string.Empty;
        public string GLTOF07Combo { get; set; } = string.Empty;
        public string GLTOF08Combo { get; set; } = string.Empty;
        public string GLTOF09Combo { get; set; } = string.Empty;
        public string GLTOF10Combo { get; set; } = string.Empty;
        public int FK_ICReceiptID { get; set; }
        public decimal ICShipmentItemDocRQty { get; set; }
        public int FK_APPInvoiceItemID { get; set; }
        public int FK_FAAssetConstructionID { get; set; }
        public decimal ICShipmentItemActQty { get; set; }
        public decimal ICShipmentItemOtherQty { get; set; }
        public int FK_ICROID { get; set; }
        public int FK_APPOID { get; set; }
        public int FK_PPProductPlnItemID { get; set; }
        public int FK_ICTransferItemID { get; set; }
        public string ICShipmentItemFGLotNo { get; set; } = string.Empty;
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public decimal ICShipmentItemFDiscAmt { get; set; }
        public int FK_APPOItemID { get; set; }
        public decimal ICShipmentItemGrossWTot { get; set; }
        public decimal ICShipmentItemNetWTot { get; set; }
        public string ICShipmentItemTAN { get; set; } = string.Empty;
        public decimal ICShipmentItemAdjStkQty { get; set; }
        public decimal ICShipmentItemAdjUnitPricePct01 { get; set; }
        public decimal ICShipmentItemAdjUnitPricePct02 { get; set; }
        public decimal ICShipmentItemAdjUnitPricePct03 { get; set; }
        public decimal ICShipmentItemAdjUnitPricePct04 { get; set; }
        public decimal ICShipmentItemAdjUnitPricePct05 { get; set; }
        public decimal ICShipmentItemAdjDiscPct01 { get; set; }
        public decimal ICShipmentItemAdjDiscPct02 { get; set; }
        public decimal ICShipmentItemAdjDiscPct03 { get; set; }
        public decimal ICShipmentItemAdjDiscPct04 { get; set; }
        public decimal ICShipmentItemAdjDiscPct05 { get; set; }
        public decimal ICShipmentItemAdjDiscFAmt01 { get; set; }
        public decimal ICShipmentItemAdjDiscFAmt02 { get; set; }
        public decimal ICShipmentItemAdjDiscFAmt03 { get; set; }
        public decimal ICShipmentItemAdjDiscFAmt04 { get; set; }
        public decimal ICShipmentItemAdjDiscFAmt05 { get; set; }
        public decimal ICShipmentItemAdjDiscAmt01 { get; set; }
        public decimal ICShipmentItemAdjDiscAmt02 { get; set; }
        public decimal ICShipmentItemAdjDiscAmt03 { get; set; }
        public decimal ICShipmentItemAdjDiscAmt04 { get; set; }
        public decimal ICShipmentItemAdjDiscAmt05 { get; set; }
        public decimal ICShipmentItemNetAmtTot { get; set; }
        public decimal ICShipmentItemFNetAmtTot { get; set; }
        public int FK_GLBudgetID { get; set; }
        public int FK_GLBudgetCfgID { get; set; }
        public int FK_GLBudgetAllocateAdjID { get; set; }
        public int FK_GLBudgetAllocateAdjItemID { get; set; }
        public int FK_GLBudgetAllocateAdjDetailID { get; set; }
        public decimal ICShipmentItemFDiscAmtTot { get; set; }
        public decimal ICShipmentItemDiscAmtTot { get; set; }
        public int FK_ICTransferID { get; set; }
        public int FK_PPProductionOrdrEstRMID { get; set; }
        public int FK_PPProductionOrdrEstFGID { get; set; }
        public Nullable<DateTime> ICShipmentItemShpDate { get; set; }
        public string ICShipmentItemAllocateTypeCombo { get; set; } = string.Empty;
        public int FK_PPWorkCenterID { get; set; }
        public string ICShipmentItemDesc1 { get; set; } = string.Empty;
        public string ICShipmentItemDesc2 { get; set; } = string.Empty;
        public string ICShipmentItemDesc3 { get; set; } = string.Empty;
        public string ICShipmentItemDesc4 { get; set; } = string.Empty;
        public string ICShipmentItemDesc5 { get; set; } = string.Empty;
        public string ICShipmentItemPONumber { get; set; } = string.Empty;
        public int FK_PPProductionOrdrRelationID { get; set; }
    }
}
