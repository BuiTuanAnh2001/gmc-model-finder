using System;

namespace gmc_api.DTO.PP
{
    public class PPProductionOrdrEstFGCreate
    {
        public int PPProductionOrdrEstFGID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public decimal PPProductionOrdrEstFGQty { get; set; }
        public decimal PPProductionOrdrEstFGMFQty { get; set; }
        public decimal PPProductionOrdrEstFGMFRQty { get; set; }
        public decimal PPProductionOrdrEstFGQCQty { get; set; }
        public decimal PPProductionOrdrEstFGRQty { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_PPRoutingID { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public decimal PPProductionOrdrEstFGStkQty { get; set; }
        public decimal PPProductionOrdrEstFGRStkQty { get; set; }
        public int FK_ICWeightUOMID { get; set; }
        public int FK_ICVolumeUOMID { get; set; }
        public decimal PPProductionOrdrEstFGWTot { get; set; }
        public decimal PPProductionOrdrEstFGVTot { get; set; }
        public decimal PPProductionOrdrEstFGFact { get; set; }
        public decimal PPProductionOrdrEstFGExcQty { get; set; }
        public decimal PPProductionOrdrEstFGOrgQty { get; set; }
        public int FK_ICOrgUOMID { get; set; }
        public decimal PPProductionOrdrEstFGCQty { get; set; }
        public int FK_PPNormID { get; set; }
        public string PPProductionOrdrEstFGLotNo { get; set; } = string.Empty;
        public int PPProductionOrdrEstFGWeek { get; set; }
        public int PPProductionOrdrEstFGPeriod { get; set; }
        public int PPProductionOrdrEstFGYear { get; set; }
        public int FK_ARShpPlanItemID { get; set; }
        public int FK_ARSOID { get; set; }
        public int FK_ARSOItemID { get; set; }
        public string PPProductionOrdrEstFGDesc { get; set; } = string.Empty;
        public decimal PPProductionOrdrEstFGNCRQty { get; set; }
        public string PPProductionOrdrEstFGNote { get; set; } = string.Empty;
        public decimal PPProductionOrdrEstFGSetupQty { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstEndDate { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_PPResourceGroupID { get; set; }
        public decimal PPProductionOrdrEstFGRcpQty { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGFODate { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGPlanDate { get; set; }
        public int FK_PPWORID { get; set; }
        public decimal PPProductionOrdrEstFGRcpCQty { get; set; }
        public decimal PPProductionOrdrEstFGCAPQty { get; set; }
        public decimal PPProductionOrdrEstFGCloseQty { get; set; }
        public int PPProductionOrdrEstFGOrder { get; set; }
        public decimal PPProductionOrdrEstFGLayout { get; set; }
        public int FK_ICLayoutUOMID { get; set; }
        public decimal PPProductionOrdrEstFGLayoutQty { get; set; }
        public int PPProductionOrdrEstFGLine { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public int FK_PPShiftID { get; set; }
        public int FK_PPProductionOrdrEstFGID { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGEndTime { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGStarTime { get; set; }
        public decimal PPProductionOrdrEstFGDownTimeQty { get; set; }
        public decimal PPProductionOrdrEstFGProductPrice { get; set; }
        public decimal PPProductionOrdrEstFGPeopleQty { get; set; }
        public int FK_ICFGProductID { get; set; }
        public decimal PPProductionOrdrEstFGProductFGQty { get; set; }
        public int FK_ICLayoutProductID { get; set; }
        public decimal PPProductionOrdrEstFGCAPSetupQty { get; set; }
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
        public string GLTOF11Combo { get; set; } = string.Empty;
        public string GLTOF12Combo { get; set; } = string.Empty;
        public string GLTOF13Combo { get; set; } = string.Empty;
        public string GLTOF14Combo { get; set; } = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        public int FK_ICProductRootID { get; set; }
        public int FK_PPWOEstFGItemID { get; set; }
        public decimal PPProductionOrdrEstFGEfficiencyQty { get; set; }
        public string PPProductionOrdrEstFGQCStatusCombo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGQCDesc { get; set; } = string.Empty;
        public Boolean PPProductionExcStkCheck { get; set; }
        public int PPProductionOrdrEstFGWOKey { get; set; }
        public int FK_HRGroupID { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstStartDate { get; set; }
        public decimal PPProductionOrdrEstFGQCValidQty { get; set; }
        public int FK_ICROID { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstDragContDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFixGoodsDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstQCGoodsDate { get; set; }
        public decimal PPProductionOrdrEstFGLastQty { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstRMDate { get; set; }
        public byte[] PPProductionOrdrEstFGBarCode { get; set; }
        public string PPProductionOrdrEstFGBarCodeNo { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGPONumber { get; set; } = string.Empty;
        public string PPProductionOrdrEstFGDesc2 { get; set; } = string.Empty;
        public decimal PPProductionOrdrEstFGWasteQty { get; set; }
        public decimal PPProductionOrdrEstFGFromRQtyDesc { get; set; }
        public string PPProductionOrdrEstFGSerialNo { get; set; } = string.Empty;
        public int FK_APPOID { get; set; }
        public int FK_APPOItemID { get; set; }
    }
}
