using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ARSOItems")]
    public class SOItemsEntity: BaseInfo
    {
        public int ARSOItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public string ARSOItemSerialNo { get; set; } = String.Empty;
        public Boolean ARSOItemIsStkItm { get; set; }
        public string ARSOItemType { get; set; } = String.Empty;
        public int ARSOItemSortOrder { get; set; }
        public string ARSOItemDesc { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 12)")] public decimal ARSOItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemUnitCost { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemRStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemPrice { get; set; }
        public string ARSOItemComment { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemUnitVolumn { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemUnitWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemCostTot { get; set; }
        public string ARSOItemStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemCAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemVTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemShpRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemShpQty { get; set; }
        public string ARSOItemShpStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemShpPlanRQty { get; set; }
        public string ARSOItemShpPlanStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemRAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemShpPlanQty { get; set; }
        public int FK_ICProductParentID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFImpTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFDiscAmt { get; set; }
        public Nullable<DateTime> ARSOItemShpDate { get; set; }= DateTime.Now;
        public int FK_ARCampaignID { get; set; }
        public int FK_ARCampaignItemID { get; set; }
        public int FK_APPOID { get; set; }
        public int FK_APPRID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemInvRQty { get; set; }
        public string ARSOItemInvStatus { get; set; } = "New";
        public int FK_AREstSOItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOnProductionQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOnWOQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOnFinishQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemPriority { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemUnitMaterialCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemMaterialCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemUnitPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOnPkgOrderQty { get; set; }
        public Nullable<DateTime> ARSOItemDeliveryDate { get; set; } = DateTime.Now;
        public int FK_ACCostSimulationMethodID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOrgQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemCQty { get; set; }
        public string ARSOItemLotNo { get; set; } = String.Empty;
        public string ARSOItemROStatusCombo { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemSaleReturnQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemCreditNoteQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemDocRQty { get; set; }
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
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPrice01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPrice02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPrice03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPrice04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPrice05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjFUnitPrice01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjFUnitPrice02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjFUnitPrice03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjFUnitPrice04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjFUnitPrice05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOrgUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemOrgFUnitPrice { get; set; }
        public string ARSOItemAutoCampaignNote { get; set; } = String.Empty;
        public string ARSOItemManualCampaignNote { get; set; } = String.Empty;
        public int FK_ARCampaignProItemID { get; set; }
        public int FK_ARCampaignItemSaleID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemDiscPrice { get; set; }
        public int FK_ICProductSaleID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemNetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFNetAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPricePct01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPricePct02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPricePct03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPricePct04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjUnitPricePct05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscPct01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscPct02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscPct03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscPct04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscPct05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscFAmt01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscFAmt02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscFAmt03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscFAmt04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscFAmt05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscAmt01 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscAmt02 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscAmt03 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscAmt04 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemAdjDiscAmt05 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemFDiscAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemDiscAmtTot { get; set; }
        public string ARSOItemPR00 { get; set; } = String.Empty;
        public string ARSOItemMWST { get; set; } = String.Empty;
        public string GLTOF11Combo { get; set; } = String.Empty;
        public string GLTOF12Combo { get; set; } = String.Empty;
        public string GLTOF13Combo { get; set; } = String.Empty;
        public string GLTOF14Combo { get; set; } = String.Empty;
        public string GLTOF15Combo { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemGrossWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemNetWTot { get; set; }
        public string ARSOItemTAN { get; set; } = String.Empty;
        public int FK_APPOItemID { get; set; }
        public Nullable<DateTime> ARSOItemPPFinishDate { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARSOItemPPFinishQty { get; set; }
        public string ARSOItemDesc1 { get; set; } = String.Empty;
        public string ARSOItemDesc2 { get; set; } = String.Empty;
        public string ARSOItemDesc3 { get; set; } = String.Empty;
        public string ARSOItemDesc4 { get; set; } = String.Empty;
        public string ARSOItemDesc5 { get; set; } = String.Empty;
        public string ARSOItemPONumber { get; set; } = String.Empty;
        public string ARSOItemPOF01Combo { get; set; } = String.Empty;
        public string ARSOItemPOF02Combo { get; set; } = String.Empty;
        public string ARSOItemPOF03Combo { get; set; } = String.Empty;
        public string ARSOItemPOF04Combo { get; set; } = String.Empty;
        public string ARSOItemPOF05Combo { get; set; } = String.Empty;
        public int FK_ARSaleForecastID { get; set; }
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
        public decimal ARSOItemExcStkQty { get; set; }
        public DateTime ARSOItemTurnOverDate { get; set; } = DateTime.Now;
        public DateTime ARSOItemETDDate { get; set; } = DateTime.Now;
        public DateTime ARSOItemETADate { get; set; } = DateTime.Now;
        public string ARSOItemLineCallOfNo { get; set; }
        public int FK_ARCustomerConID { get; set; }
        //
        public int VirtualID;
        public List<ARSOItemSaleForecastItemsInfo> lstARSOItemSaleForecastItems { get; set; } = new List<ARSOItemSaleForecastItemsInfo>();
        public List<ARSOItemContractItemsInfo> lstARSOItemContractItems { get; set; } = new List<ARSOItemContractItemsInfo>();
        public List<ARQuotItemSOItemsInfo> lstARQuotItemSOItems { get; set; } = new List<ARQuotItemSOItemsInfo>();
        public List<ARSOBOMItemsInfo> lstARSOBOMItems { get; set; }= new List<ARSOBOMItemsInfo>();
        public List<ARSOItemPOItemsInfo> lstARSOItemPOItems { get; set; } = new List<ARSOItemPOItemsInfo>();
    }
}
