using System;

namespace gmc_api.DTO.PP
{
    public class ProdRstItemsInfo
    {
        public int itemID { get; set; }
        public string remark { get; set; } = "";
        public int productId { get; set; }
        public string productNo { get; set; }
        public string productName { get; set; }
        public int resourceId { get; set; }
        public string resourceNo { get; set; }
        public string resourceName { get; set; }
        public int phaseId { get; set; }
        public string phaseNo { get; set; }
        public string phaseName { get; set; }
        public string unit { get; set; }

        public decimal qty { get; set; }
        public decimal cancelQty { get; set; } = 0;
        public decimal setUpQty { get; set; } = 0;
        public decimal NCRQty { get; set; } = 0;
        public string qcStatus { get; set; } = null;
        public string qcDescription { get; set; } = null;
        public decimal dQty { get; set; }
        public decimal rQty { get; set; }
        public decimal PPProductionOrdrEstFGDownTimeQty { get; set; }
        public decimal PPProductionOrdrEstFGWasteQty { get; set; }
        public string tof05Name { get; set; }
        public string tof05No { get; set; }
        public string oldCode { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGStarTime { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstFGEndTime { get; set; }
        public int FK_PPWOEstFGItemID { get; set; }
        public byte[] PPProductionOrdrEstFGBarCode { get; set; }
        public string PPProductionOrdrEstFGBarCodeNo { get; set; }
        public string PPProductionOrdrEstFGSerialNo { get; set; }
        public string PPProductionOrdrEstFGLotNo { get; set; }
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public string icstkUOMNo { get; set; }
        public decimal PPProductionOrdrEstFGStkQty { get; set; }
        public int FK_PPWOID { get; set; }
        public decimal PPProductionOrdrEstFGBarQty { get; set; }
        public string GLTOF01Combo { get; set; } = string.Empty;
        public string GLTOF02Combo { get; set; }  = string.Empty;
        public string GLTOF03Combo { get; set; }  = string.Empty;
        public string GLTOF04Combo { get; set; }  = string.Empty;
        public string GLTOF05Combo { get; set; }  = string.Empty;
        public string GLTOF06Combo { get; set; }  = string.Empty;
        public string GLTOF07Combo { get; set; }  = string.Empty;
        public string GLTOF08Combo { get; set; }  = string.Empty;
        public string GLTOF09Combo { get; set; }  = string.Empty;
        public string GLTOF10Combo { get; set; }  = string.Empty;
        public string GLTOF11Combo { get; set; }  = string.Empty;
        public string GLTOF12Combo { get; set; }  = string.Empty;
        public string GLTOF13Combo { get; set; }  = string.Empty;
        public string GLTOF14Combo { get; set; }  = string.Empty;
        public string GLTOF15Combo { get; set; } = string.Empty;
        //public int FK_PPWOPlanID { get; set; }
        //public string PPWOPlanNo { get; set; }
        //public string PPWOPlanDesc { get; set; }
    }
}
