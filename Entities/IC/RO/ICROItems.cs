using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICROItems")]
    public class ICROItems
    {
        [Key]
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
        [Column(TypeName = "decimal(19, 12)")] public decimal ICROItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemUnitCost { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemRStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPrice { get; set; }
        public string ICROItemComment { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemUnitVol { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemUnitWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemCostTot { get; set; }
        public string ICROItemStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemCAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemVTot { get; set; }
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
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFImpTxAmt { get; set; }
        public int FK_GLDebitAccountID { get; set; }
        public int FK_GLCreditAccountID { get; set; }
        public int FK_GLDebitVATAccountID { get; set; }
        public int FK_GLCreditVATAccountID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAllocateLife { get; set; }
        public int FK_FAAssetID { get; set; }
        public int FK_HRDepartmentID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAssetLife { get; set; }
        public int FK_ARCampaignID { get; set; }
        public int FK_ARCampaignItemID { get; set; }
        public int FK_ARCreditNoteItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemSaleReturnRQty { get; set; }
        public string ICROItemSaleReturnStatusCombo { get; set; } = "New";
        public string ICROItemLotNo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APSOItemFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemDriverPmtAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemDriverPmtPct { get; set; }
        public Boolean ICROItemIsValidInv { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAllocateQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemRequestQty { get; set; }
        public string ICPackageLockTypeCombo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPurchaseReturnRQty { get; set; }
        public string ICROItemPurchaseReturnStatusCombo { get; set; } = "New";
        public Boolean ICROItemIsCostingItemCheck { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public int FK_GLCostDistID { get; set; }
        public int FK_PPPkgOrderItemID { get; set; }
        public int FK_GLCostCenterID { get; set; }
        public int FK_GLTranCfgID { get; set; }
        public int FK_PPWOID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemTransferRQty { get; set; }
        public string ICROItemTransferStatusCombo { get; set; } = "New";
        public int FK_APPOItemID { get; set; }
        public int FK_APPOBOMItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemWOQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPOBOMQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPOBOMRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPOBOMRqtQty { get; set; }
        public int FK_PPProductionOrdrEstRMID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemOrgQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemCQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemDocRQty { get; set; }
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
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFDiscAmt { get; set; }
        public string ICROItemManufacturer { get; set; } = string.Empty;
        public int FK_ARContractParentItemID { get; set; }
        public string ICROItemFGLotNo { get; set; } = string.Empty;
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemGrossWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemNetWTot { get; set; }
        public string ICROItemTAN { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPricePct01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPricePct02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPricePct03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPricePct04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPricePct05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscPct01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscPct02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscPct03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscPct04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscPct05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscFAmt01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscFAmt02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscFAmt03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscFAmt04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscFAmt05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscAmt01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscAmt02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscAmt03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscAmt04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjDiscAmt05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemNetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFNetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemFDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemEstQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemActQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemUnitPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemEstPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemActPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAvaiQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemEstPkgPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemActPkgPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemCheckQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemCheckPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemCheckPrice { get; set; }
        public int FK_ARShpPlanItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal PPPkgOrderItemContQty { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemActpQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPackingCoefficient { get; set; }
        public string ICROItemDesc1 { get; set; } = string.Empty;
        public string ICROItemDesc2 { get; set; } = string.Empty;
        public string ICROItemDesc3 { get; set; } = string.Empty;
        public string ICROItemDesc4 { get; set; } = string.Empty;
        public string ICROItemDesc5 { get; set; } = string.Empty;
        public int FK_HRGroupID { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public int FK_PPResourceID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemTransferCQty { get; set; }
        public string ICROItemNotReport { get; set; } = string.Empty;
        public string ICROItemPOF01Combo { get; set; } = string.Empty;
        public string ICROItemPOF02Combo { get; set; } = string.Empty;
        public string ICROItemPOF03Combo { get; set; } = string.Empty;
        public string ICROItemPOF04Combo { get; set; } = string.Empty;
        public string ICROItemPOF05Combo { get; set; } = string.Empty;
        public string ICROItemFGPOF01Combo { get; set; } = string.Empty;
        public string ICROItemFGPOF02Combo { get; set; } = string.Empty;
        public string ICROItemFGPOF03Combo { get; set; } = string.Empty;
        public string ICROItemFGPOF04Combo { get; set; } = string.Empty;
        public string ICROItemFGPOF05Combo { get; set; } = string.Empty;
        public Nullable<DateTime> ICROItemExpiredDate { get; set; }
        public int FK_PPWOEstRMItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemContQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemContFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemKitQty { get; set; }
        public int FK_ICProductRootID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemPkgQty { get; set; }
        public int FK_ICPkgUOMID { get; set; }
        public int FK_PPMaintenanceOID { get; set; }
        public int FK_PPDeviceID { get; set; }
        public int FK_PPMaintenanceORMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemExcStkQty { get; set; }
        public string GLTOF16Combo { get; set; } = string.Empty;
        public string GLTOF17Combo { get; set; } = string.Empty;
        public string GLTOF18Combo { get; set; } = string.Empty;
        public string GLTOF19Combo { get; set; } = string.Empty;
        public string GLTOF20Combo { get; set; } = string.Empty;
        public string GLTOF21Combo { get; set; } = string.Empty;
        public string GLTOF22Combo { get; set; } = string.Empty;
        public string GLTOF23Combo { get; set; } = string.Empty;
        public string GLTOF24Combo { get; set; } = string.Empty;
        public string GLTOF25Combo { get; set; } = string.Empty;
        public string GLTOF26Combo { get; set; } = string.Empty;
        public string GLTOF27Combo { get; set; } = string.Empty;
        public string GLTOF28Combo { get; set; } = string.Empty;
        public string GLTOF29Combo { get; set; } = string.Empty;
        public string GLTOF30Combo { get; set; } = string.Empty;
        public string GLTOF31Combo { get; set; } = string.Empty;
        public string GLTOF32Combo { get; set; } = string.Empty;
        public string GLTOF33Combo { get; set; } = string.Empty;
        public string GLTOF34Combo { get; set; } = string.Empty;
        public string GLTOF35Combo { get; set; } = string.Empty;
        public int FK_ARInvoiceItemID { get; set; }
        public int FK_PPToolManagementItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPrice01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPrice02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPrice03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPrice04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjUnitPrice05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjFUnitPrice01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjFUnitPrice02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjFUnitPrice03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjFUnitPrice04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemAdjFUnitPrice05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemOrgUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICROItemOrgFUnitPrice { get; set; }
        public string ICROItemPONumber { get; set; } = string.Empty; 

    }
}
