using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    public class ICROItemCreateRequest
    {
        public int ICROItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_ICROID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARInvoiceID { get; set; }
        public string ICROItemSerialNo { get; set; } = string.Empty;
        public string ICROItemType { get; set; } = string.Empty;
        public Boolean ICROItemIsStkItm { get; set; }
        public string ICROItemDesc { get; set; } = string.Empty;
        public decimal ICROItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = string.Empty;
        public decimal ICROItemUnitPrice { get; set; }
        public decimal ICROItemUnitCost { get; set; }
        public decimal ICROItemDiscPct { get; set; }
        public decimal ICROItemTxPct { get; set; }
        public decimal ICROItemQty { get; set; }
        public decimal ICROItemStkQty { get; set; }
        public decimal ICROItemRQty { get; set; }
        public decimal ICROItemRStkQty { get; set; }
        public decimal ICROItemPrice { get; set; }
        public string ICROItemComment { get; set; } = string.Empty;
        public decimal ICROItemUnitVol { get; set; }
        public decimal ICROItemUnitWeight { get; set; }
        public decimal ICROItemTxAmt { get; set; }
        public decimal ICROItemDiscAmt { get; set; }
        public decimal ICROItemNetAmt { get; set; }
        public decimal ICROItemAmtTot { get; set; }
        public decimal ICROItemCostTot { get; set; }
        public string ICROItemStatus { get; set; } = "New";
        public decimal ICROItemAmt { get; set; }
        public decimal ICROItemCAmt { get; set; }
        public decimal ICROItemWTot { get; set; }
        public decimal ICROItemVTot { get; set; }
        public int FK_LOShpPlanID { get; set; }
        public int ICROItemSortOrder { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_ARCustomerID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICProductIDWO { get; set; }
        public int FK_HRDerpamentID { get; set; }
        public int FK_ICReceiptItemID { get; set; }
        public Nullable<DateTime> ICROItemExpireDate { get; set; }
        public int FK_ICProductParentID { get; set; }
        public decimal ICROItemFUnitPrice { get; set; }
        public decimal ICROItemFPrice { get; set; }
        public decimal ICROItemFTxAmt { get; set; }
        public decimal ICROItemFNetAmt { get; set; }
        public decimal ICROItemFAmtTot { get; set; }
        public decimal ICROItemFImpTxAmt { get; set; }
        public int FK_GLDebitAccountID { get; set; }
        public int FK_GLCreditAccountID { get; set; }
        public int FK_GLDebitVATAccountID { get; set; }
        public int FK_GLCreditVATAccountID { get; set; }
        public decimal ICROItemAllocateLife { get; set; }
        public int FK_FAAssetID { get; set; }
        public int FK_HRDepartmentID { get; set; }
        public decimal ICROItemAssetLife { get; set; }
        public int FK_ARCampaignID { get; set; }
        public int FK_ARCampaignItemID { get; set; }
        public int FK_ARCreditNoteItemID { get; set; }
        public decimal ICROItemSaleReturnRQty { get; set; }
        public string ICROItemSaleReturnStatusCombo { get; set; } = "New";
        public string ICROItemLotNo { get; set; } = string.Empty;
        public decimal APSOItemFUnitPrice { get; set; }
        public decimal ICROItemDriverPmtAmt { get; set; }
        public decimal ICROItemDriverPmtPct { get; set; }
        public Boolean ICROItemIsValidInv { get; set; }
        public decimal ICROItemAllocateQty { get; set; }
        public decimal ICROItemRequestQty { get; set; }
        public string ICPackageLockTypeCombo { get; set; } = string.Empty;
        public decimal ICROItemPurchaseReturnRQty { get; set; }
        public string ICROItemPurchaseReturnStatusCombo { get; set; } = "New";
        public Boolean ICROItemIsCostingItemCheck { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public int FK_GLCostDistID { get; set; }
        public int FK_PPPkgOrderItemID { get; set; }
        public int FK_GLCostCenterID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_PPWOID { get; set; }
        public decimal ICROItemTransferRQty { get; set; }
        public string ICROItemTransferStatusCombo { get; set; } = "New";
        public int FK_APPOItemID { get; set; }
        public int FK_APPOBOMItemID { get; set; }
        public decimal ICROItemWOQty { get; set; }
        public decimal ICROItemPOBOMQty { get; set; }
        public decimal ICROItemPOBOMRQty { get; set; }
        public decimal ICROItemPOBOMRqtQty { get; set; }
        public int FK_PPProductionOrdrEstRMID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal ICROItemOrgQty { get; set; }
        public decimal ICROItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        public decimal ICROItemCQty { get; set; }
        public decimal ICROItemDocRQty { get; set; }
        public Nullable<DateTime> ICROItemShpDate { get; set; }
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
        public int FK_ARContractItemID { get; set; }
        public string ICROItemOrigin { get; set; } = string.Empty;
        public string ICROItemProductNo { get; set; } = string.Empty;
        public string ICROItemProductName { get; set; } = string.Empty;
        public int FK_PPWOPItemID { get; set; }
        public decimal ICROItemFDiscAmt { get; set; }
        public string ICROItemManufacturer { get; set; } = string.Empty;
        public int FK_ARContractParentItemID { get; set; }
        public string ICROItemFGLotNo { get; set; } = string.Empty;
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public decimal ICROItemGrossWTot { get; set; }
        public decimal ICROItemNetWTot { get; set; }
        public string ICROItemTAN { get; set; } = string.Empty;
        public decimal ICROItemAdjStkQty { get; set; }
        public decimal ICROItemAdjUnitPricePct01 { get; set; }
        public decimal ICROItemAdjUnitPricePct02 { get; set; }
        public decimal ICROItemAdjUnitPricePct03 { get; set; }
        public decimal ICROItemAdjUnitPricePct04 { get; set; }
        public decimal ICROItemAdjUnitPricePct05 { get; set; }
        public decimal ICROItemAdjDiscPct01 { get; set; }
        public decimal ICROItemAdjDiscPct02 { get; set; }
        public decimal ICROItemAdjDiscPct03 { get; set; }
        public decimal ICROItemAdjDiscPct04 { get; set; }
        public decimal ICROItemAdjDiscPct05 { get; set; }
        public decimal ICROItemAdjDiscFAmt01 { get; set; }
        public decimal ICROItemAdjDiscFAmt02 { get; set; }
        public decimal ICROItemAdjDiscFAmt03 { get; set; }
        public decimal ICROItemAdjDiscFAmt04 { get; set; }
        public decimal ICROItemAdjDiscFAmt05 { get; set; }
        public decimal ICROItemAdjDiscAmt01 { get; set; }
        public decimal ICROItemAdjDiscAmt02 { get; set; }
        public decimal ICROItemAdjDiscAmt03 { get; set; }
        public decimal ICROItemAdjDiscAmt04 { get; set; }
        public decimal ICROItemAdjDiscAmt05 { get; set; }
        public decimal ICROItemNetAmtTot { get; set; }
        public decimal ICROItemFNetAmtTot { get; set; }
        public decimal ICROItemFDiscAmtTot { get; set; }
        public decimal ICROItemDiscAmtTot { get; set; }
        public decimal ICROItemEstQty { get; set; }
        public decimal ICROItemActQty { get; set; }
        public decimal ICROItemUnitPkgCBM { get; set; }
        public decimal ICROItemEstPkgCBM { get; set; }
        public decimal ICROItemActPkgCBM { get; set; }
        public decimal ICROItemAvaiQty { get; set; }
        public decimal ICROItemEstPkgPrice { get; set; }
        public decimal ICROItemActPkgPrice { get; set; }
        public decimal ICROItemCheckQty { get; set; }
        public decimal ICROItemCheckPkgCBM { get; set; }
        public decimal ICROItemCheckPrice { get; set; }
        public int FK_ARShpPlanItemID { get; set; }
        public decimal PPPkgOrderItemContQty { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public decimal ICROItemActpQty { get; set; }
        public decimal ICROItemPackingCoefficient { get; set; }
        public string ICROItemDesc1 { get; set; } = string.Empty;
        public string ICROItemDesc2 { get; set; } = string.Empty;
        public string ICROItemDesc3 { get; set; } = string.Empty;
        public string ICROItemDesc4 { get; set; } = string.Empty;
        public string ICROItemDesc5 { get; set; } = string.Empty;
        public int FK_HRGroupID { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public int FK_PPResourceID { get; set; }
        public decimal ICROItemTransferCQty { get; set; }
        public string ICROItemNotReport { get; set; } = string.Empty;

    }
}
