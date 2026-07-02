using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("APPRBOMItems")]
    public class APPRBOMItemsInfo 
    {
        [Key]
        public int APPRBOMItemID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public Boolean AASelected { get; set; }
        public int FK_APPRID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICProductTypeID { get; set; }
        public int FK_ARPriceListID { get; set; }
        public string APPRBOMItemSerialNo { get; set; } = string.Empty;
        public Boolean APPRBOMItemIsStkItm { get; set; }
        public string APPRBOMItemType { get; set; } = string.Empty;
        public int APPRBOMItemSortOrder { get; set; }
        public string APPRBOMItemDesc { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFact { get; set; }
        public string ARSalePriceCombo { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemUnitCost { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemDiscPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemTxPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemOrgQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemRStkQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemPrice { get; set; }
        public string APPRBOMItemComment { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemUnitVolumn { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemUnitWeight { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemAmtTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemCostTot { get; set; }
        public string APPRBOMItemStatus { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemCAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemVTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemShpRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemShpQty { get; set; }
        public string APPRBOMItemShpStatus { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemShpPlanRQty { get; set; }
        public string APPRBOMItemShpPlanStatus { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemRAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemShpPlanQty { get; set; }
        public int FK_ICProductParentID { get; set; }
        public int FK_APPRItemID { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFTxAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFDiscAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFNetAmt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFAmtTot { get; set; }
        public string APPRBOMItemAttrValue { get; set; } = string.Empty;
        public string APPRBOMItemAttrName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemSortValue { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemRqtQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemFactor { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemAllocatePct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal APPRBOMItemAdjStkQty { get; set; }

    }
}
