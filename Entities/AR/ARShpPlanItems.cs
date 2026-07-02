using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ARShpPlanItems")]
    public class ARShpPlanItems : BaseInfo
    {
        [Key]
        public int ARShpPlanItemID { get; set; }
        public Nullable<DateTime> AACreatedDate { get; set; }
        public string AACreatedUser { get; set; } = string.Empty;
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public string AAUpdatedUser { get; set; } = string.Empty;
        public string AAStatus { get; set; } = string.Empty;
        public Boolean AASelected { get; set; }
        public int ARShpPlnItemPeriod { get; set; }
        public int ARShpPlnItemYear { get; set; }
        public int FK_ARShpPlanID { get; set; }
        public int FK_ICProductID { get; set; }
        public string ICProductName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ICProductLength { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICProductWidth { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICProductHeght { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ICProductCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemPriority { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemSaleQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemMinStock { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemInvActual { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemNTSQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemATSQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemATSPct { get; set; }
        public int ARShpPlanItemATSCnt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemHTSQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemHTSPct { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstPOQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemOnPOQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstPORQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemOnPORQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemOnPORcpQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemLastPORQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemDiffQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstProductionQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemMinShpQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemModifyCnt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemPlannedSemiProductionQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemPlannedFGProductionQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemNeedToProcessQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemFWInvQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstProductionCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemTotalCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemMaterialCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemUnitPrice { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemAmtTotal { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemMaterialTotalCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemNeedToProcessCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemOnWOFWInvQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemNTSPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstPOPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstProductionPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemNeedToProcessPkgCBM { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemSemiDetailInvQty { get; set; }
        public int ARShpPlanItemOrdrPlnModifyCnt { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemOnSemiWO { get; set; }
        public int FK_ARSOID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemOnWO { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemFinishQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstRcp { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemLastAccumulateAllocateQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemAllocateQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemAccumulateAllocateQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemEstSemiInvQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemAllocateSemiInvQty { get; set; }
        public string ARShpPlanItemNeedPO { get; set; } = string.Empty;
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemATSAmtTotal { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemHTSAmtTotal { get; set; }
        public Nullable<DateTime> ARShpPlanItemDueDate { get; set; }
        public int FK_ARSOItemID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemWTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemVTot { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemFact { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemStkQty { get; set; }
        public int FK_ICStkUOMID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemCQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemDocRQty { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemAdjStkQty { get; set; }
        public string ARShpPlanItemLotNo { get; set; } = string.Empty;
        public int FK_ICStockID { get; set; }
        [Column(TypeName = "decimal(19, 6)")] public decimal ARShpPlanItemFUnitPrice { get; set; }
        public int FK_ICPkgUOMID { get; set; }
        public string ARShpPlanItemDesc1 { get; set; } = string.Empty;
        public string ARShpPlanItemDesc2 { get; set; } = string.Empty;
        public string ARShpPlanItemDesc3 { get; set; } = string.Empty;
        public string ARShpPlanItemDesc4 { get; set; } = string.Empty;
        public string ARShpPlanItemDesc5 { get; set; } = string.Empty;
        public string ARShpPlanItemSerialNo { get; set; } = string.Empty;
        public int FK_ICStockSlotID { get; set; }
        public string ARShpPlanItemPOF01Combo { get; set; } = string.Empty;
        public string ARShpPlanItemPOF02Combo { get; set; } = string.Empty;
        public string ARShpPlanItemPOF03Combo { get; set; } = string.Empty;
        public string ARShpPlanItemPOF04Combo { get; set; } = string.Empty;
        public string ARShpPlanItemPOF05Combo { get; set; } = string.Empty;

    }
}
