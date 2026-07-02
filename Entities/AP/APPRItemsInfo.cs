using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("APPRItems")]
    public class APPRItemsInfo
    {
        [Key]
        public int APPRItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public string APPRItemStatus { get; set; } = "New";
        public int FK_APPRID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public string APPRItemSerialNo { get; set; } = String.Empty;
        public Boolean APPRItemIsStkItm { get; set; }
        public string APPRItemType { get; set; } = String.Empty;
        public int APPRItemSrtOrder { get; set; }
        public string APPRItemDesc { get; set; } = String.Empty;
        public string APPRItemSellUnit { get; set; } = String.Empty;
        public string APPRItemBasicUnit { get; set; } = String.Empty;
        public string APPRItemPackUnit { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemSellFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemPackFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemUnitCost { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemGrpDisc { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemDisc { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQtyOld { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemBasicQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemPckQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty1 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty2 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty3 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty4 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty5 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemQty6 { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemPrice { get; set; }
        public string APPRItemComment { get; set; } = String.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemUnitVolumn { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemUnitWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemCostTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemFTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemFDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemFPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemFAmtTot { get; set; }
        public Nullable<DateTime> APPRItemArrivalDate { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemMinStockQty { get; set; }
        public Nullable<DateTime> APPRItemUseDate { get; set; }
        public string APPRItemUsePurposes { get; set; } = String.Empty;
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemRStkQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemVTot { get; set; }
        public int FK_ARSOID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemExcQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemOrgQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemCQty { get; set; }
        public string APPRItemProductNo { get; set; } = String.Empty;
        public string APPRItemProductName { get; set; } = String.Empty;
        public string APPRItemLine { get; set; } = String.Empty;
        public int FK_APSupplierID { get; set; }
        public int FK_APRFQItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemInvQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemBOQQty { get; set; }
        public string APPRItemOrigin { get; set; } = String.Empty;
        public int FK_APProcurementPlnItemID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemAdjStkQty { get; set; }
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
        public int FK_GLBudgetCfgID { get; set; }
        public int FK_GLBudgetAllocateAdjID { get; set; }
        public int FK_GLBudgetAllocateAdjDetailID { get; set; }
        public int FK_APPRItemFromID { get; set; }
        public int FK_APPriceListID { get; set; }
        public int FK_ARCampaignID { get; set; }
        public string GLIOF01Combo { get; set; } = String.Empty;
        public string GLIOF02Combo { get; set; } = String.Empty;
        public string GLIOF03Combo { get; set; } = String.Empty;
        public string GLIOF04Combo { get; set; } = String.Empty;
        public string GLIOF05Combo { get; set; } = String.Empty;
        public string GLIOF06Combo { get; set; } = String.Empty;
        public string GLIOF07Combo { get; set; } = String.Empty;
        public string GLIOF08Combo { get; set; } = String.Empty;
        public string GLIOF09Combo { get; set; } = String.Empty;
        public string GLIOF10Combo { get; set; } = String.Empty;
        public string APPRItemAPPriceListStatus { get; set; } = "New";
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRItemUsedTime { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPWOEstFGItemID { get; set; }
        public string APPRItemFGLotNo { get; set; } = String.Empty;
        public int FK_PPWOMRPID { get; set; }
        public int FK_ICFGProductID { get; set; }
        public int FK_PPWOMRPItemID { get; set; }
        public string APPRItemPOF01Combo { get; set; } = String.Empty;
        public string APPRItemPOF02Combo { get; set; } = String.Empty;
        public string APPRItemPOF03Combo { get; set; } = String.Empty;
        public string APPRItemPOF04Combo { get; set; } = String.Empty;
        public string APPRItemPOF05Combo { get; set; } = String.Empty;
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
