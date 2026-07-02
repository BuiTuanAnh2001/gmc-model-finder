using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("APPOBOMItems")]
    public class APPOBOMItemsInfo
    {
        [Key]
        public int APPOBOMItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_APPOID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public string APPOBOMItemSerialNo { get; set; } = string.Empty;
        public Boolean APPOBOMItemIsStkItm { get; set; }
        public string APPOBOMItemType { get; set; } = string.Empty;
        public int APPOBOMItemSortOrder { get; set; }
        public string APPOBOMItemDesc { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemUnitPrice { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemUnitCost { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemDiscPct { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemTxPct { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemStkQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemRQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemRStkQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemPrice { get; set; }
        public string APPOBOMItemComment { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemUnitVolumn { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemUnitWeight { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemTxAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemDiscAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemNetAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemAmtTot { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemCostTot { get; set; }
        public string APPOBOMItemStatus { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemCAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemWTot { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemVTot { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemShpRQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemShpQty { get; set; }
        public string APPOBOMItemShpStatus { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemShpPlanRQty { get; set; }
        public string APPOBOMItemShpPlanStatus { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemRAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemShpPlanQty { get; set; }
        public int FK_ICProductParentID { get; set; }
        public int FK_APPOItemID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFUnitPrice { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFPrice { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFTxAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFDiscAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFNetAmt { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFAmtTot { get; set; }
        public string APPOBOMItemAttrValue { get; set; } = string.Empty;
        public string APPOBOMItemAttrName { get; set; } = string.Empty;
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemSortValue { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemRqtQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemFactor { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemAllocatePct { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemAdjStkQty { get; set; }
       [Column(TypeName = "decimal(19, 6)")] public decimal APPOBOMItemOrgQty { get; set; }
        public string APPOBOMItemPOF01Combo { get; set; } = string.Empty;
        public string APPOBOMItemPOF02Combo { get; set; } = string.Empty;
        public string APPOBOMItemPOF03Combo { get; set; } = string.Empty;
        public string APPOBOMItemPOF04Combo { get; set; } = string.Empty;
        public string APPOBOMItemPOF05Combo { get; set; } = string.Empty;
    }
}
